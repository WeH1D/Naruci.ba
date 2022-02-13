using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using NaruciBa.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class ProizvodService : BaseCRUDService<Model.Proizvod, Database.Proizvod, ProizvodSearchObject, ProizvodInsertRequest, ProizvodUpdateRequest>, IProizvodService
    {
        ImageHelper imageHelper = new ImageHelper();

        public ProizvodService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<Model.Proizvod> Insert(ProizvodInsertRequest request)
        {
            var entity = _mapper.Map<Database.Proizvod>(request);
            await Context.Proizvods.AddAsync(entity);
            await Context.SaveChangesAsync();

            if (request.Slika != null)
            {
                entity.SlikaPutanja = await imageHelper.InsertImage("Proizvod", entity.ProizvodID, request.SlikaPutanja, request.Slika);
                await Context.SaveChangesAsync();
            }


            Podkategorija podKategorijaProizvoda = await Context.Podkategorijas.FindAsync(request.PodkategorijaID);
            Poslovnica poslovnica = await Context.Poslovnicas.FindAsync(request.PoslovnicaID);

            var daliPostoji = Context.TrgovackiLanacKategorijas
                .Where(a => a.KategorijaID == podKategorijaProizvoda.KategorijaID && a.TrgovackiLanacID == poslovnica.TrgovackiLanacID)
                .Count();

            // Dodaj kategoriju za odredeni trgovacki lanac samo ukoliko ta kategorija vec nije dodjeljena tom trgovackom lancu
            if (daliPostoji == 0)
            {
                TrgovackiLanacKategorija trgovackiLanacKategorija = new TrgovackiLanacKategorija()
                {
                    KategorijaID = podKategorijaProizvoda.KategorijaID,
                    TrgovackiLanacID = poslovnica.TrgovackiLanacID
                };
                await Context.TrgovackiLanacKategorijas.AddAsync(trgovackiLanacKategorija);
                await Context.SaveChangesAsync();
            }

            return _mapper.Map<Model.Proizvod>(entity);
        }

        public async override Task<IEnumerable<Model.Proizvod>> Get(ProizvodSearchObject search = null)
        {
            var entity = Context.Set<Database.Proizvod>().AsQueryable();
            if(!string.IsNullOrEmpty(search.Naziv))
            {
                entity = entity.Where(a => a.Naziv.Contains(search.Naziv));
            }
            if (!string.IsNullOrEmpty(search.Sifra))
            {
                entity = entity.Where(a => a.Sifra.Contains(search.Sifra));
            }
            if(search.PoslovnicaID.HasValue)
            {
                entity = entity.Where(a => a.PoslovnicaID == search.PoslovnicaID);
            }
            if(search.PodkategorijaID.HasValue)
            {
                entity = entity.Where(a => a.PodkategorijaID == search.PodkategorijaID);
            }
            if(search.KategorijaID.HasValue)
            {
                entity = entity.Include(a => a.Podkategorija).Where(a => a.Podkategorija.KategorijaID == search.KategorijaID);
            }
            if(search.IncludeList?.Count > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }
            entity = entity.Where(a => a.Status != false);
            var list = await entity.ToListAsync();
            var result = _mapper.Map<List<Model.Proizvod>>(list);

            foreach (var item in result)
            {
                var directory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "Proizvod", $"{item.SlikaPutanja}");
                item.Slika = await imageHelper.FindImage(directory);
            }

            return result;
        }

        public async override Task<Model.Proizvod> GetById(int id)
        {
            var entity = await Context.Proizvods.FindAsync(id);

            var result = _mapper.Map<Model.Proizvod>(entity);

            var directory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "Proizvod", $"{result.SlikaPutanja}");
            result.Slika = await imageHelper.FindImage(directory);

            return result;
        }

        public async override Task<Model.Proizvod> Delete(int id)
        {
            var entity = await Context.Proizvods
                .Include(a=>a.Poslovnica)
                .Include(a=>a.Podkategorija)
                .Where(a=> a.ProizvodID == id)
                .FirstOrDefaultAsync();

            var result = await base.Delete(id);

            // Svi proizvodi u istoj kategoriji za dati trgovacki lanac
            var products = await Context.Proizvods
                .Include(a => a.Poslovnica)
                .Include(a => a.Podkategorija)
                .Where(a => a.Poslovnica.TrgovackiLanacID == entity.Poslovnica.TrgovackiLanacID && a.Podkategorija.KategorijaID == entity.Podkategorija.KategorijaID)
                .ToListAsync();

            // Ako nema vise proizvoda u toj kategoriji za dati trgovacki lanac, izbrisi odgovarajuci data u TrgovackiLanacKategorija
            if(products.Count() == 0){
                var trgovackiLanacKategorija = await Context.TrgovackiLanacKategorijas
                    .Where(a => a.KategorijaID == entity.Podkategorija.KategorijaID && a.TrgovackiLanacID == entity.Poslovnica.TrgovackiLanacID)
                    .FirstOrDefaultAsync();
                Context.TrgovackiLanacKategorijas.Remove(trgovackiLanacKategorija);
                await Context.SaveChangesAsync();
            }

            return result;
        }
    }
}
