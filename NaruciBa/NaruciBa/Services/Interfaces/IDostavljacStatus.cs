using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface IDostavljacStatus : ICRUDService<Model.DostavljacStatus, object, Model.Requests.DostavljacStatusUpsertRequest, Model.Requests.DostavljacStatusUpsertRequest>
    {
    }
}
