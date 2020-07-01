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
    public class RolesController : ControllerBase
    {
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public RolesController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }


        // GET: api/Roles
        [HttpGet]
        public IActionResult Get(
            [FromQuery] RoleSearch search,
            [FromServices] IGetRolesQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }


        // GET: api/Roles/5
        [HttpGet("{id}", Name = "GetRole")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Roles
        [HttpPost]
        public void Post([FromBody] RoleDto dto,
            [FromServices] ICreateRoleCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }

        // PUT: api/Roles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteRoleCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}
