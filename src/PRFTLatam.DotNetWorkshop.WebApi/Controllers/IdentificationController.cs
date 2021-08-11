using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using PRFTLatam.DotNetWorkshop.Services.Logic;
using System.Collections.Generic;

namespace PRFTLatam.DotNetWorkshop.WebApi.Controllers
{
    [ApiController]
    [Route("api/identification")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class IdentificationController : ControllerBase
    {
        private ValidateId validateId;
        private readonly ILogger<HealthCheckController> _logger;

        public IdentificationController(ILogger<HealthCheckController> logger){
            _logger =logger;
            validateId = new ValidateId();
            }

        [HttpGet("{id}")] 
        public ActionResult Check(String id){
            _logger.LogInformation("{0}-HealthCheckExecuted", DateTime.Now.ToString("yyyy-MM-ddHH:mm:ss"));
            validateId.setIdentification(id);
            List<String> errors = validateId.ValidateIdentification();

            if(errors.Count != 0){
                return UnprocessableEntity(errors);
            }
            return Ok();
            }
    }
}