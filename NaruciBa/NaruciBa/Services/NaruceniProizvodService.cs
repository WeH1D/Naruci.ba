using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class NaruceniProizvodService : BaseCRUDService<Model.NaruceniProizvod, Database.NaruceniProizvod, Model.SearchObjects.NaruceniPorizvodSearchObject, Model.Requests.NaruceniProizvodUpsertRequest, Model.Requests.NaruceniProizvodUpsertRequest>, Interfaces.INaruceniProizvod
    {
        public NaruceniProizvodService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async override Task<IEnumerable<Model.NaruceniProizvod>> Get(Model.SearchObjects.NaruceniPorizvodSearchObject search = null)
        {

            var entity = Context.Set<Database.NaruceniProizvod>().AsQueryable();
            if (search.NarudzbaID.HasValue)
            {
                entity = entity.Where(a => a.NarudzbaID == search.NarudzbaID);
            }
       
            var list = await entity.ToListAsync();
            return _mapper.Map<List<Model.NaruceniProizvod>>(list);
        }
    }
}
