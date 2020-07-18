using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dd.Application;
using dd.Application.Commands;
using dd.Application.Queries;
using dd.Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoceController : ControllerBase
    {


        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public InvoceController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/Invoce
        public IActionResult Get(
            [FromQuery] InvoceSearch search,
            [FromServices] IGetInvoceQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET: api/Invoce/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Invoce
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Invoce/5
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
