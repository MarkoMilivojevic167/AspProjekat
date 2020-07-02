using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspProjekat.Application;
using AspProjekat.Application.Commands;
using AspProjekat.Application.DataTransfer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspProjekat.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public ImagesController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }
        public void Post([FromForm] ImageDto dto, [FromServices] IUploadImageCommand command)
        {
            executor.ExecuteCommand(command, dto);
        }



    }
}
