using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicCalculatorApp.Models;
using BasicCalculatorAppLibrary;

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
            SimpleCalc calc = new SimpleCalc();
            cal.result = calc.OperatorSwitch(cal.firstNum,cal.secondNum,op);
            return View(cal);
        }

    }
}
