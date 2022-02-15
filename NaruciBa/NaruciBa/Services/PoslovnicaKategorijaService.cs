using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Model;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class PoslovnicaKategorijaService : BaseReadService<PoslovnicaKategorija, Database.PoslovnicaKategorija,PoslovnicaKategorijaSearchObject>, IPoslovnicaKategorijaService
    {
        public PoslovnicaKategorijaService(Database.NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async override Task<IEnumerable<Model.PoslovnicaKategorija>> Get(PoslovnicaKategorijaSearchObject search = null)
        {
            var entity = Context.Set<Database.PoslovnicaKategorija>().AsQueryable();
            if (search.PoslovnicaID.HasValue)
            {
                entity = entity.Where(a => a.PoslovnicaID == search.PoslovnicaID);
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<Model.PoslovnicaKategorija>>(list);
        }
    }
}
