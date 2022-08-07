using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using NaruciBa.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class KoordinatorService : BaseCRUDService<Model.Koordinator, Database.Koordinator, Model.SearchObjects.KoordinatorSearchObject, Model.Requests.KoordinatorInsertRequest, Model.Requests.KoordinatorInsertRequest>, Interfaces.IKoordinatorService
    {
        public KoordinatorService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override async Task<IEnumerable<Model.Koordinator>> Get(KoordinatorSearchObject search = null)
        {
            var entity = Context.Set<Database.Koordinator>().AsQueryable();
            if (search.KorisnikID.HasValue)
            {
                entity = entity.Where(a => a.KorisnikID == search.KorisnikID);
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<Model.Koordinator>>(list);
        }
    }
}
