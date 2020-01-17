using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PS.Common.Entity;

namespace Tenten.Clinet.Api.Contorllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseController : Controller
    {
        private readonly TraceId _traceId;
        private readonly ILogger<BaseController> _logger;


        public BaseController(TraceId traceId,
            ILogger<BaseController> logger)
        {
            _traceId = traceId;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> t1()
        {

            _logger.LogDebug("테스트");
            //throw new Exception();
            return Ok("오예1");
        }

    }
}