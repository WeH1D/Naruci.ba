using NaruciBa.Model;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class TrgovackiLanacController : BaseCRUDController<Model.TrgovackiLanac, object, TrgovackiLanacUpsertRequest, TrgovackiLanacUpsertRequest>
    {
        public TrgovackiLanacController(ITrgovackiLanacService service) 
            : base(service)
        {
        }
    }
}
