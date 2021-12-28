using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface IPodkategorijaService : ICRUDService<Model.Podkategorija, PodkategorijaSearchObject, PodkategorijaUpsertRequest, PodkategorijaUpsertRequest>
    {
    }
}
