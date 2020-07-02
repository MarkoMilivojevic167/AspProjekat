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
    public class UserController : ControllerBase
    {

        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public UserController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }
        // GET: api/User
        [HttpGet]
        public IActionResult Get([FromQuery] UserSearch search, [FromServices] IGetUserQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "getOneUser")]
        public IActionResult Get([FromRoute]int id, [FromServices] IGetOneUserQuery query)
        {
            return Ok(executor.ExecuteQuery(query, id));
        }

        // POST: api/User
        [HttpPost]
        public void Post(
            [FromBody] RegisterUserDto dto, [FromServices] IRegisterUserCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }

        // PUT: api/User/5
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
