using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using NaruciBa.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class TrgovackiLanacService : BaseCRUDService<Model.TrgovackiLanac, Database.TrgovackiLanac, object, TrgovackiLanacUpsertRequest, TrgovackiLanacUpsertRequest>, ITrgovackiLanacService
    {
        public ImageHelper imageHelper = new ImageHelper();
        public TrgovackiLanacService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<Model.TrgovackiLanac> Insert(TrgovackiLanacUpsertRequest request)
        {
            var entity = _mapper.Map<Database.TrgovackiLanac>(request);
            await Context.TrgovackiLanacs.AddAsync(entity);
            await Context.SaveChangesAsync();

            entity.SlikaPutanja = await imageHelper.InsertImage("TrgovackiLanac", entity.TrgovackiLanacID, request.SlikaPutanja, request.Slika);
            await Context.SaveChangesAsync();

            return _mapper.Map<Model.TrgovackiLanac>(entity);
        }
    }
}
