using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class NarudzbaService : BaseCRUDService<Model.Narudzba, Database.Narudzba, Model.SearchObjects.NarudzbaSearchObject, Model.Requests.NarudzbaUpsertRequest, Model.Requests.NarudzbaUpsertRequest>, Interfaces.INarudzbaService
    {
        public NarudzbaService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
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
            if (search.IncludeList?.Count > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<Model.Narudzba>>(list);
        }
    }
}
