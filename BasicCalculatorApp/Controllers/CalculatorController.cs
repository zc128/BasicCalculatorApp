using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicCalculatorApp.Models;

namespace BasicCalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }
        [HttpPost]
        public IActionResult Index(Calculator cal, string op)
        {

            switch (op) {
                case "Add":
                    cal.result = (cal.firstNum + cal.secondNum).ToString();
                    break;
                case "Subtract":
                    cal.result = (cal.firstNum - cal.secondNum).ToString();
                    break;
                case "Multiply":
                    cal.result = (cal.firstNum * cal.secondNum).ToString();
                    break;
                case "Divide":
                    if (cal.secondNum != 0)
                    {
                        cal.result = (cal.firstNum / cal.secondNum).ToString();
                    }
                    else {
                        cal.result = "ERROR: SecondNum CAN'T be 0 in Division!";
                    }
                    break;
                default:
                    cal.result = 0.ToString();
                    break;
            }
             
            return View(cal);
        }

    }
}
