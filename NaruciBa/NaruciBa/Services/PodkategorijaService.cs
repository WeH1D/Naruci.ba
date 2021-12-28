using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class PodkategorijaService: BaseCRUDService<Model.Podkategorija, Database.Podkategorija, PodkategorijaSearchObject, PodkategorijaUpsertRequest, PodkategorijaUpsertRequest>, IPodkategorijaService
    {
        public PodkategorijaService(NaruciBaContext context, IMapper mapper)
           : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Podkategorija> Get(PodkategorijaSearchObject search = null)
        {
            var entity = Context.Set<Database.Podkategorija>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(a => a.Naziv.Contains(search.Naziv));
            }

            if (search.KategorijaID.HasValue)
            {
                entity = entity.Where(a => a.KategorijaID == search.KategorijaID);
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.Podkategorija>>(list);
        }
    }
}
