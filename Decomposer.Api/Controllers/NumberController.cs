using Decomposer.Domain.Creator;
using Decomposer.Domain.Entities;
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
    [Route("api/[controller]")]
    public class NumberController : ControllerBase
    {
        private readonly IDecomposeService _dividerService;
        private readonly NumberFactoryMethod _numberFactory;
        public NumberController(IDecomposeService dividerService, NumberFactoryMethod numberFactory)
        {
            _dividerService = dividerService;
            _numberFactory = numberFactory;
        }

        [HttpGet, Route("{number}")]
        public IActionResult Get(int number)
        {
            var decomposeNumber = _numberFactory.MakeDecomposeNumber(number);
            _dividerService.DecompouseNumber(decomposeNumber);
            var result = _numberFactory.ReturnResult(decomposeNumber);
            _dividerService.CalculatedCousinPrime(result);
            return new JsonResult(Ok()) { ContentType = "json/Serialization", StatusCode = 200, Value = result };
        }
    }
}
