using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class PoslovnicaService : BaseCRUDService<Model.Poslovnica, Database.Poslovnica, PoslovnicaSearchObject, PoslovnicaInsertRequest, PoslovnicaUpdateRequest>, IPoslovnicaService
    {
        public PoslovnicaService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<IEnumerable<Model.Poslovnica>> Get(PoslovnicaSearchObject search = null)
        {
            var entity = Context.Set<Database.Poslovnica>().AsQueryable();
            if(search.GradID.HasValue)
            {
                entity = entity.Include(a => a.Grad).Where(a => a.Grad.GradID == search.GradID);
            }
            if(search.TrgovackiLanacID.HasValue)
            {
                entity = entity.Include(a => a.TrgovackiLanac).Where(a => a.TrgovackiLanac.TrgovackiLanacID == search.TrgovackiLanacID);
            }
            if(search.IncludeList?.Count > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }
            entity = entity.Where(a => a.Status == true);
            var list = await entity .ToListAsync();
            return _mapper.Map<List<Model.Poslovnica>>(list);
        }
        public async override Task<Model.Poslovnica> GetById(int id)
        {
            var entity = await Context.Poslovnicas.FindAsync(id);
            if (entity.Status)
                return await base.GetById(id);
            else
                throw new Exception("No available poslovnica with given id.");
        }
        public async override Task<Model.Poslovnica> Delete(int id)
        {
            var entity = Context.Set<Database.Poslovnica>().Find(id);
            entity.Status = false;
            await Context.SaveChangesAsync();
            return _mapper.Map<Model.Poslovnica>(entity);
        }
    }
}
