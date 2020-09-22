using ALamarDiReplacement.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALamarDiReplacement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IDBManager _dBManager;
        private ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger, IDBManager dBManager)
        {
            
            _dBManager = dBManager;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Hello from Values Controller");
            return Ok("42");
        }
    }
}
