using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dd.Application;
using dd.Application.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayListController : ControllerBase
    {


        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public PlayListController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/PlayList
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PlayList/5
        [HttpGet("{id}", Name = "getPlaylist")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PlayList
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PlayList/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteInvoceCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}
