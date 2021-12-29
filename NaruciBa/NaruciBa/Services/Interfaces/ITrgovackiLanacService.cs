using NaruciBa.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface ITrgovackiLanacService : ICRUDService<Model.TrgovackiLanac, object, TrgovackiLanacUpsertRequest, TrgovackiLanacUpsertRequest>
    {
    }
}
