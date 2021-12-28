using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class PodkategorijaController : BaseReadController<Model.Podkategorija>
    {
        public PodkategorijaController(IPodkategorijaService service)
            : base(service)
        {

        }
    }
}
