using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class KlijentService : BaseReadService<Model.Klijent, Database.Klijent, Model.SearchObjects.KlijentSearchObject>, Interfaces.IKlijentService
    {
        public KlijentService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async override Task<IEnumerable<Model.Klijent>> Get(Model.SearchObjects.KlijentSearchObject search = null)
        {
            var entity = Context.Set<Database.Klijent>().AsQueryable();
            if (search.KorisnikID.HasValue)
            {
                entity = entity.Where(a => a.KorisnikID == search.KorisnikID);
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<Model.Klijent>>(list);
        }
    }
}
