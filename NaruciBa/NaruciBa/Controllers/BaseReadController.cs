using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseReadController<T, TSearch> : ControllerBase where T: class where TSearch: class
    {
        protected readonly IReadService<T, TSearch> _service;

        public BaseReadController(IReadService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public async virtual Task<IEnumerable<T>> Get([FromQuery] TSearch search)
        {
            return await _service.Get(search);
        }

        [HttpGet("{id}")]
        public async virtual Task<T> GetById(int id)
        {
            return await _service.GetById(id);
        }
    }
}
