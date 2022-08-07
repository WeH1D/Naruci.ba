using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface IKoordinatorService : ICRUDService<Model.Koordinator, Model.SearchObjects.KoordinatorSearchObject, Model.Requests.KoordinatorInsertRequest, Model.Requests.KoordinatorInsertRequest>
    {
    }
}
