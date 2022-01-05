using Microsoft.AspNetCore.Authorization;
using NaruciBa.Model;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    public class KategorijaController : BaseCRUDController<Model.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        public KategorijaController(IKategorijaService service) 
            : base(service)
        {
        }
    }
}
