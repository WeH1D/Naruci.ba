using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T : class where TDb : class where TSearch : class
    {
        public NaruciBaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public BaseReadService(NaruciBaContext context, IMapper mapper)
        {
            _mapper = mapper;
            Context = context;
        }

        public async virtual Task<IEnumerable<T>> Get(TSearch search = null)
        {
            var set = Context.Set<TDb>();
            var list = await set.ToListAsync();
            return _mapper.Map<List<T>>(list);
        }

        public async virtual Task<T> GetById(int id)
        {
            var set = Context.Set<TDb>();
            var entity = await set.FindAsync(id);
            return _mapper.Map<T>(entity);
        }
    }
}
