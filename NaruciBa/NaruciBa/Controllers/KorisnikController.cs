using NaruciBa.Model.Requests;
using NaruciBa.Services;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class KorisnikController: BaseCRUDController<Model.Korisnik, Model.SearchObjects.KorisnikSearchObject, KorisnikInsertRequest, KorisnikInsertRequest>
    {
        public KorisnikController(IKorisnikService service)
            : base(service)
        {
        }
    }
}
