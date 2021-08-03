using CalculateEverything.Models;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public IActionResult SquareArea(VariablesModel model, string button)
        {
            if (!ModelState.IsValid)
            { 
                return View(); 
            }
                if (button == "buttonFirst")
                {
                    model.Result = Math.Pow(model.SquareSide, 2);
                    ViewBag.ResultArea = model.Result;
                }
                if (button == "buttonSecond")
                {
                    model.Result = Math.Round((Math.Pow(model.SquareDiagonal, 2)) / 2, 2);
                    ViewBag.ResultArea2 = model.Result;
                }
                if (button == "buttonThird")
                {
                    model.Result = Math.Round(model.SquareSide * Math.Sqrt(2), 2);
                    ViewBag.ResultDiagonal = model.Result.ToString();
                }
                if (button == "buttonFourth")
                {
                    model.Result = model.SquareSide * 4;
                    ViewBag.ResultCircuit = model.Result;
                }
            
                return View();
        }
       

        [HttpGet]
        public IActionResult RectangleArea()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RectangleArea(VariablesModel model)
        {
            model.Result = model.FristRectangleSide * model.SecondRectangleSide;
            ViewBag.Result = model.Result;
            return View();
        }
        [HttpGet]
        public IActionResult TriangleArea()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TriangleArea(VariablesModel model)
        {
            model.Result = (model.TriangleBaseLine * model.TriangleHeight) / 2;
            ViewBag.Result = model.Result;
            return View();
        }
    }
}
