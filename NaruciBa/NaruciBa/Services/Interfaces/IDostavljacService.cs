using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface IDostavljacService: ICRUDService<Model.Dostavljac, Model.SearchObjects.DostavljacSearchObject, Model.Requests.DostavljacUpsertRequest, Model.Requests.DostavljacUpsertRequest>
    {
    }
}
