using NaruciBa.Services;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class KorisnikController: BaseReadController<Model.Korisnik, object>
    {
        public KorisnikController(IKorisnikService service)
            : base(service)
        {
        }
    }
}
