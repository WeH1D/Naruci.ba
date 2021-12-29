using NaruciBa.Model;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class GradController : BaseReadController<Model.Grad, object>
    {
        public GradController(IGradService service) 
            : base(service)
        {
        }
    }
}
