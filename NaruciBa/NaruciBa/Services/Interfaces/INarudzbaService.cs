using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface INarudzbaService : ICRUDService<Model.Narudzba, Model.SearchObjects.NarudzbaSearchObject, Model.Requests.NarudzbaUpsertRequest, Model.Requests.NarudzbaUpsertRequest>
    {
    }
}
