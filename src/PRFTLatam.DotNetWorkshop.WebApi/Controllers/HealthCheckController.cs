using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace PRFTLatam.DotNetWorkshop.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class HealthCheckController : ControllerBase
    {
        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger){
            _logger=logger;
            }

        [HttpGet] 
        public OkResult Check(){
            _logger.LogInformation("{0}-HealthCheckExecuted", DateTime.Now.ToString("yyyy-MM-ddHH:mm:ss"));
            return Ok();
            }
    }
}