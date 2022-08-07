using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class KoordinatorController : BaseCRUDController<Model.Koordinator, Model.SearchObjects.KoordinatorSearchObject, Model.Requests.KoordinatorInsertRequest, Model.Requests.KoordinatorInsertRequest>
    {
        public KoordinatorController(IKoordinatorService service) : base(service)
        {
        }
    }
}
