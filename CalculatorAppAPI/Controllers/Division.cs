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
    public class Division : ControllerBase
    {
        [HttpGet]
        public string Get([FromQuery] decimal leftNumber, [FromQuery] decimal rightNumber)
        {
            SimpleCalc calc = new SimpleCalc();
            decimal result;
            result = calc.divisionFunc(leftNumber, rightNumber);
            if (result == decimal.MinValue) 
            {
                return "Error: the rightNumber can't be zero";
            }
            else { 
            return result.ToString();
            }
        }

        [HttpPost]
        public string Post([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            SimpleCalc calc = new SimpleCalc();
            decimal result;
            result = calc.divisionFunc(leftNumber, rightNumber);
            if (result == decimal.MinValue)
            {
                return "Error: the rightNumber can't be zero";
            }
            else
            {
                return result.ToString();
            }
        }

        [HttpOptions]
        public dynamic Options()
        {
            Response.ContentType = "application/json";
            var json = new
            {
                HttpGet = "Use the FromQuery parameters to get the leftNumber and " +
                "rightNumber variables and get a result, and it will show an Error string says " +
                "the rightNumber can't be zero if the value of rightNumber is zero",
                HttpPost = "Use the FromForm parameters to get the leftNumber and " +
                "rightNumber variables and get a result, and it will show an Error string says " +
                "the rightNumber can't be zero if the value of rightNumber is zero",
            };

            return json;
        }
    }
}
