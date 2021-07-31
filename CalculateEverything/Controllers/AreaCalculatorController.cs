using CalculateEverything.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEverything.Controllers
{
    public class AreaCalculatorController : Controller
    {
        private readonly VariablesModel _model;

        public AreaCalculatorController(VariablesModel model)
        {
            _model = model;
        }
        [HttpGet]
        public IActionResult SquareArea()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SquareArea(VariablesModel model)
        {
            model.Result = Math.Pow(model.SquareSide, 2);
            return View(model);
        }
    }
}
