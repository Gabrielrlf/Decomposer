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
        private readonly IDecomposeService _decomposeService;
        private readonly NumberFactoryMethod _numberFactory;
        public NumberController(IDecomposeService dividerService, NumberFactoryMethod numberFactory)
        {
            _decomposeService = dividerService;
            _numberFactory = numberFactory;
        }

        /// <summary>
        /// Decompõe um número passado via query string.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet("{Num}")]
        public IActionResult DecomposerNumber(int num)
        {
            try
            {
                var result = _decomposeService.MakeOperation(num);
                return new JsonResult(Ok()) { ContentType = "application/json", StatusCode = 200, Value = result };
            }
            catch (Exception e)
            {
                return new JsonResult(BadRequest(e)) { StatusCode = 500, Value = e.Message };
            }
        }


        /// <summary>
        /// Decompõe múltiplos números passados via json.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        [HttpPost("MultiplesNumber")]
        public IActionResult DecomposerMultiplesNumber([FromBody] List<int> numbers)
        {
            try
            {
                List<ResultNumberDecomposed> listResult = new();
                numbers.ForEach(x => listResult.Add(_decomposeService.MakeOperation(x)));
                return new JsonResult(Ok()) { ContentType = "application/json", StatusCode = 200, Value = listResult };
            }
            catch (Exception e)
            {
                return new JsonResult(BadRequest(e)) { StatusCode = 500, Value = e.Message};
            }
        }
    }
}
