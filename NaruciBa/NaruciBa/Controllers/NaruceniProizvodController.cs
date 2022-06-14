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
    public class NaruceniProizvodController : BaseCRUDController<Model.NaruceniProizvod, Model.SearchObjects.NaruceniPorizvodSearchObject, Model.Requests.NaruceniProizvodUpsertRequest, Model.Requests.NaruceniProizvodUpsertRequest>
    {
        public NaruceniProizvodController(INaruceniProizvod service) : base(service)
        {
        }
    }
}
