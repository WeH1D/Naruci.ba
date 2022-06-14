using Microsoft.AspNetCore.Mvc;
using NaruciBa.Model;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class KlijentController : BaseReadController<Model.Klijent, Model.SearchObjects.KlijentSearchObject>
    {
        public KlijentController(IKlijentService service) : base(service)
        {
        }
    }
}
