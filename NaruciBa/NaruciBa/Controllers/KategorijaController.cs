using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class KategorijaController : BaseCRUDController<Model.Kategorija, KategorijaSearchObject, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        public IKategorijaService kategorijaService;
        public KategorijaController(IKategorijaService service) 
            : base(service)
        {
            kategorijaService = service;
        }

        [HttpGet]
        [Route("getKategorijeFromProizvodiList")]
        public async virtual Task<List<Model.Kategorija>> getKategorijeFromProizvodiList([FromQuery] KategorijaSearchObject search)
        {
            return await kategorijaService.getKategorijeFromProizvodiList(search);
        }
    }
}
