using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface IPoslovnicaService : ICRUDService<Model.Poslovnica, PoslovnicaSearchObject, PoslovnicaInsertRequest, PoslovnicaUpdateRequest>
    {
    }
}
