using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface INaruceniProizvod : ICRUDService<Model.NaruceniProizvod, Model.SearchObjects.NaruceniPorizvodSearchObject, Model.Requests.NaruceniProizvodUpsertRequest, Model.Requests.NaruceniProizvodUpsertRequest>
    {
    }
}
