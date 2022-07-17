using NaruciBa.Model;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class DostavljacController : BaseCRUDController<Model.Dostavljac, Model.SearchObjects.DostavljacSearchObject, Model.Requests.DostavljacUpsertRequest, Model.Requests.DostavljacUpsertRequest>
    {
        public DostavljacController(IDostavljacService service) : base(service)
        {
        }
    }
}
