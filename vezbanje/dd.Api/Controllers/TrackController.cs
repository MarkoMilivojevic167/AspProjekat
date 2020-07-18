using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dd.Application;
using dd.Application.Commands;
using dd.Application.DataTransfer;
using dd.Implementation.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {


        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public TrackController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/Track
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Track/5
        [HttpGet("{id}", Name = "GetTrack")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Track
        [HttpPost]
        public void Post([FromBody] TrackDto dto,
            [FromServices] ICreateTrackCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }

        // PUT: api/Track/5
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
