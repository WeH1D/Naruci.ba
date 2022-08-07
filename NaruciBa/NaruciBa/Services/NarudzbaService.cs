using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class NarudzbaService : BaseCRUDService<Model.Narudzba, Database.Narudzba, Model.SearchObjects.NarudzbaSearchObject, Model.Requests.NarudzbaUpsertRequest, Model.Requests.NarudzbaUpsertRequest>, Interfaces.INarudzbaService
    {
        ImageHelper imageHelper = new ImageHelper();
        public NarudzbaService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override async Task<Model.Narudzba> Insert(NarudzbaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Narudzba>(request);
            await Context.Narudzbas.AddAsync(entity);
            await Context.SaveChangesAsync();

            if (request.SlikaRacuna != null)
            {
                entity.SlikaRacunaPutanja = await imageHelper.InsertImage("Narudzba", entity.NarudzbaID, request.SlikaRacunaPutanja, request.SlikaRacuna);
                await Context.SaveChangesAsync();
            }

            return _mapper.Map<Model.Narudzba>(entity);
        }
        public override async Task<Model.Narudzba> Update(int id, NarudzbaUpsertRequest request)
        {
            if (request.SlikaRacuna != null)
            {
                request.SlikaRacunaPutanja = await imageHelper.InsertImage("Narudzba", id, request.SlikaRacunaPutanja, request.SlikaRacuna);
            }

            return await base.Update(id, request);
        }
        public async override Task<IEnumerable<Model.Narudzba>> Get(Model.SearchObjects.NarudzbaSearchObject search = null)
        {
            if (search.KlijentID.HasValue)
            {
                var postojecaNarudzba = Context.Narudzbas.Where(a => a.KlijentID == search.KlijentID);
                if(!postojecaNarudzba.Any())
                {
                    Database.Narudzba novaNarudzba = new Narudzba()
                    {
                        KlijentID = search.KlijentID,
                        BonusZaDostavljaca = null,
                        Datum = DateTime.Now,
                        DostavljacID = null,
                        KoordinatorID = null,
                        KuponID = null,
                        NarudzbaStatusID = 1,
                        PoslovnicaID = null,
                        SlikaRacunaPutanja = null,
                        UkupanIznos = 0
                    };
                    await Context.Narudzbas.AddAsync(novaNarudzba);
                    await Context.SaveChangesAsync();
                }
            }

            if (search.NarudzbaStatusID.HasValue && search.NarudzbaStatusID == 1)
            {
                var postojecaNarudzba = Context.Narudzbas.Where(a => a.KlijentID == search.KlijentID && a.NarudzbaStatusID == search.NarudzbaStatusID);
                if (!postojecaNarudzba.Any())
                {
                    Database.Narudzba novaNarudzba = new Narudzba()
                    {
                        KlijentID = search.KlijentID,
                        BonusZaDostavljaca = null,
                        Datum = DateTime.Now,
                        DostavljacID = null,
                        KoordinatorID = null,
                        KuponID = null,
                        NarudzbaStatusID = 1,
                        PoslovnicaID = null,
                        SlikaRacunaPutanja = null,
                        UkupanIznos = 0
                    };
                    await Context.Narudzbas.AddAsync(novaNarudzba);
                    await Context.SaveChangesAsync();
                }
            }

            var entity = Context.Set<Database.Narudzba>().AsQueryable();
            if (search.KlijentID.HasValue)
            {
                entity = entity.Where(a => a.KlijentID == search.KlijentID);
            }
            if (search.KoordinatorID .HasValue)
            {
                entity = entity.Where(a => a.KlijentID == search.KlijentID);
            }
            if (search.PoslovnicaID.HasValue)
            {
                entity = entity.Where(a => a.PoslovnicaID == search.PoslovnicaID);
            }
            if (search.DostavljacID.HasValue)
            {
                entity = entity.Where(a => a.DostavljacID == search.DostavljacID);
            }
            if (search.Datum.HasValue)
            {
                entity = entity.Where(a => a.Datum == search.Datum);
            }
            if (search.NarudzbaStatusID.HasValue)
            {
                entity = entity.Where(a => a.NarudzbaStatusID == search.NarudzbaStatusID);
            }
            if (search.excludeNarudzbaWithStatusId.HasValue)
            {
                entity = entity.Where(a => a.NarudzbaStatusID != search.excludeNarudzbaWithStatusId);
            }
            if (search.IncludeList?.Count > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }
            var list = await entity.ToListAsync();
            var result = _mapper.Map<List<Model.Narudzba>>(list);

            foreach (var item in result)
            {
                var directory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "Narudzba", $"{item.SlikaRacunaPutanja}");
                item.SlikaRacuna = await imageHelper.FindImage(directory);
            }

            return result;
        }
        public override async Task<Model.Narudzba> GetById(int id)
        {
            var entity = await Context.Narudzbas.FindAsync(id);

            var result = _mapper.Map<Model.Narudzba>(entity);

            var directory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "Narudzba", $"{result.SlikaRacunaPutanja}");
            result.SlikaRacuna = await imageHelper.FindImage(directory);

            return result;
        }
    }
}
