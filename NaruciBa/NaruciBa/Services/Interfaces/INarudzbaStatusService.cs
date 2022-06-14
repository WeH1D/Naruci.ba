using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface INarudzbaStatusService: ICRUDService<Model.NarudzbaStatus, Model.SearchObjects.NarudzbaStatusSearchObject, Model.Requests.NarudzbaStatusUpsertRequest, Model.Requests.NarudzbaStatusUpsertRequest>
    {
    }
}
