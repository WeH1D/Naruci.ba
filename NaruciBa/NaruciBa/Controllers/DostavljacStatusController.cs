using NaruciBa.Model;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class DostavljacStatusController : BaseCRUDController<Model.DostavljacStatus, object, Model.Requests.DostavljacStatusUpsertRequest, Model.Requests.DostavljacStatusUpsertRequest>
    {
        public DostavljacStatusController(IDostavljacStatus service) : base(service)
        {
        }
    }
}
