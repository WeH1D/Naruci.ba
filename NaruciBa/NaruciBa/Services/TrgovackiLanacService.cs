using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class TrgovackiLanacService : BaseCRUDService<Model.TrgovackiLanac, Database.TrgovackiLanac, object, TrgovackiLanacUpsertRequest, TrgovackiLanacUpsertRequest>, ITrgovackiLanacService
    {
        public TrgovackiLanacService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }
    }
}
