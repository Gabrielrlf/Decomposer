using Decomposer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decomposer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberController : ControllerBase
    {
        private readonly IDecomposeService _dividerService;
        private readonly ILogger<NumberController> _logger;

        public NumberController(IDecomposeService dividerService) => _dividerService = dividerService;
        

        /*[HttpGet]
        public IActionResult<> Get()
        {

        }*/
    }
}
