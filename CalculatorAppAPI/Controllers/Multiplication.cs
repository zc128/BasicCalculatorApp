using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicCalculatorAppLibrary;

namespace CalculatorAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Multiplication : ControllerBase
    {
        [HttpGet]
        public string Get([FromQuery] decimal leftNumber, [FromQuery] decimal rightNumber)
        {
            SimpleCalc calc = new SimpleCalc();
            decimal result;
            result = calc.multiplicationFunc(leftNumber, rightNumber);
            return result.ToString();
        }

        [HttpPost]
        public string Post([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            SimpleCalc calc = new SimpleCalc();
            decimal result;
            result = calc.multiplicationFunc(leftNumber, rightNumber);
            return result.ToString();
        }

        [HttpOptions]
        public dynamic Options()
        {
            Response.ContentType = "application/json";
            var json = new
            {
                HttpGet = "Use the FromQuery parameters to get the leftNumber and rightNumber variables and get a result",
                HttpPost = "Use the FromForm parameters to get the leftNumber and rightNumber variables and get a result",
            };

            return json;
        }
    }
}
