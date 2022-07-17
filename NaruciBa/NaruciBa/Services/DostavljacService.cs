using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class DostavljacService : BaseCRUDService<Model.Dostavljac, Database.Dostavljac, Model.SearchObjects.DostavljacSearchObject, Model.Requests.DostavljacUpsertRequest, Model.Requests.DostavljacUpsertRequest>, Interfaces.IDostavljacService
    {
        public DostavljacService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async override Task<IEnumerable<Model.Dostavljac>> Get(Model.SearchObjects.DostavljacSearchObject search = null)
        {
            var entity = Context.Set<Database.Dostavljac>().AsQueryable();
            if (search.KorisnikID.HasValue)
            {
                entity = entity.Where(a => a.KorisnikID == search.KorisnikID);
            }
            if (search.dostavljacStatusId.HasValue)
            {
                entity = entity.Where(a => a.DostavljacStatus == search.dostavljacStatusId);
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<Model.Dostavljac>>(list);
        }
    }
}
