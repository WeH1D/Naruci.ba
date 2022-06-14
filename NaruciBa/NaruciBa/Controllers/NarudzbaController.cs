using NaruciBa.Model;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class NarudzbaController : BaseCRUDController<Model.Narudzba, Model.SearchObjects.NarudzbaSearchObject, Model.Requests.NarudzbaUpsertRequest, Model.Requests.NarudzbaUpsertRequest>
    {
        public NarudzbaController(INarudzbaService service) : base(service)
        {
        }
    }
}
