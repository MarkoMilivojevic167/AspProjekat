using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProjekat.Application;
using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Queries;
using AspProjekat.Application.Searches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspProjekat.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public CategoriesController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/Categories
        [HttpGet]
        public IActionResult Get(
            [FromQuery] CategorySearch search,
            [FromServices] IGetCategoriesQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET: api/Categories/5
        [HttpGet("{id}", Name = "GetCategory")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Categories
        [HttpPost]
        public void Post([FromBody] CategoryDto dto,
            [FromServices] ICreateCategoryCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteCategoryCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}
