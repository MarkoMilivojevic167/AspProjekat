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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public ProductController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }
        // GET: api/Product
        [HttpGet]
        public IActionResult Get(
            [FromQuery] ProductSearch search,
            [FromServices] IGetProductQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "getOneProduct")]
        public IActionResult Get([FromRoute]int id, [FromServices] IGetOneProductQuery query)
        {
            return Ok(executor.ExecuteQuery(query, id));
        }

        // POST: api/Product
        [Authorize]
        [HttpPost]
        public void Post([FromBody] ProductDto dto,
            [FromServices] ICreateProductCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }

        // PUT: api/Product/5
        [Authorize]
        [HttpPut]
        public void Put([FromForm] UpdateProductDto dto, [FromServices] IUpdateProductCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }

        // DELETE: api/ApiWithActions/5
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteProductCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}
