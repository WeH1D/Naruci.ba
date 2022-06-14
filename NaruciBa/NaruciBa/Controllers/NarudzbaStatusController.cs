using NaruciBa.Model;
using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class NarudzbaStatusController : BaseCRUDController<Model.NarudzbaStatus, Model.SearchObjects.NarudzbaStatusSearchObject, Model.Requests.NarudzbaStatusUpsertRequest, Model.Requests.NarudzbaStatusUpsertRequest>
    {
        public NarudzbaStatusController(INarudzbaStatusService service) : base(service)
        {
        }
    }
}
