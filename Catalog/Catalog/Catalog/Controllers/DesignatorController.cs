using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Models.DomainModels;
using Catalog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignatorController : ControllerBase
    {
        private readonly DesignatorService _service;
        public DesignatorController(DesignatorService service)
        {
            _service = service;
        }

        // GET: api/Designator
        [HttpGet]
        public IEnumerable<Designator> Get()
        {
            return _service.GetAll();
        }

        // GET: api/Designator/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Designator
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Designator/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
