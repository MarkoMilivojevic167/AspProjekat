using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProjekat.Application;
using AspProjekat.Application.Queries;
using AspProjekat.Application.Searches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspProjekat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseCaseLogController : ControllerBase
    {
        private readonly UseCaseExecutor executor;

        public UseCaseLogController(UseCaseExecutor executor)
        {
            this.executor = executor;
        }

        // GET: api/UseCaseLog
        [Authorize]
        [HttpGet]
        public IActionResult Get([FromQuery] UseCaseSearch search, [FromServices] IGetUseCaseQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

    }
}
