using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseReadService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate> where T : class where TDb : class where TSearch : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public virtual T Insert(TInsert request)
        {
            var set = Context.Set<TDb>();
            TDb entity = _mapper.Map<TDb>(request);
            set.Add(entity);
            Context.SaveChanges();
            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            _mapper.Map(request, entity);
            Context.SaveChanges();
            return _mapper.Map<T>(entity);
        }
    }
}
