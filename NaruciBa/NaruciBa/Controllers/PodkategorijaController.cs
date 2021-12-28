using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class PodkategorijaController : BaseCRUDController<Model.Podkategorija, PodkategorijaSearchObject, PodkategorijaUpsertRequest, PodkategorijaUpsertRequest>
    {
        public PodkategorijaController(IPodkategorijaService service)
            : base(service)
        {

        }
    }
}
