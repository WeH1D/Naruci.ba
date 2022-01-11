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

            entity.SlikaPutanja = await imageHelper.InsertImage("Proizvod", entity.ProizvodID, request.SlikaPutanja, request.Slika);
            await Context.SaveChangesAsync();

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
    }
}
