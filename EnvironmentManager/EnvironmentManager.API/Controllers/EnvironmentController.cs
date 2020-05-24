using EnvironmentManager.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EnvironmentManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentController : ControllerBase
    {
        private readonly IEnvironmentRepository environmentRepository;

        public EnvironmentController(IEnvironmentRepository environmentRepository)
        {
            this.environmentRepository = environmentRepository;
        }

        // GET: api/Environment
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(JsonConvert.SerializeObject(environmentRepository.GetAllEnvironmentsAsync()));
        }

        // GET: api/Environment/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(JsonConvert.SerializeObject(environmentRepository.GetEnvironmentByIdAsync(id)));
        }

        // POST: api/Environment
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Environment/5
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
