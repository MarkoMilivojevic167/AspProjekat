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
    public class OrdersController : ControllerBase
    {
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public OrdersController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/Orders
        [HttpGet]
        public IActionResult Get([FromQuery] OrderSearch search, [FromServices] IGetOrdersQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "getOneOrder")]
        public IActionResult Get([FromRoute]int id, [FromServices] IGetOneOrderQuery query)
        {
            return Ok(executor.ExecuteQuery(query, id));
        }

        // POST: api/Orders
        [HttpPost]
        public void Post([FromBody] CreateOrderDto dto, [FromServices] ICreateOrderCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }


        [HttpPost("changestatus")]
        public void PromenaStatusa([FromBody] ChnageOrderStatusDto dto, [FromServices]IChangeStatusOrderCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }
    }
}
