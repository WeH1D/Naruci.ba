using NaruciBa.Model;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class PoslovnicaKategorijaController : BaseReadController<PoslovnicaKategorija, PoslovnicaKategorijaSearchObject>
    {
        public PoslovnicaKategorijaController(IPoslovnicaKategorijaService service) : base(service)
        {
        }
    }
}
