using AutoMapper;
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

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var set = Context.Set<TDb>();
            var list = set.ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }
    }
}
