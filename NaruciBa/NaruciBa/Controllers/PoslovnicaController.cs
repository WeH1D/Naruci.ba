using Microsoft.AspNetCore.Authorization;
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
    public class PoslovnicaController : BaseCRUDController<Model.Poslovnica, PoslovnicaSearchObject, PoslovnicaInsertRequest, PoslovnicaUpdateRequest>
    {
        public PoslovnicaController(IPoslovnicaService service) 
            : base(service)
        {
        }
    }
}
