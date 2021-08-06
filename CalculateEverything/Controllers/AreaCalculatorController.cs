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
        public IActionResult Square()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Square(VariablesModel model, string button)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (button == "buttonFirst")
            {
                model.Result = Math.Pow(model.SquareSide, 2);
                ViewBag.ResultArea = model.Result.ToString();
            }
            if (button == "buttonSecond")
            {
                model.Result = Math.Round((Math.Pow(model.SquareDiagonal, 2)) / 2, 2);
                ViewBag.ResultArea2 = model.Result.ToString();
            }
            if (button == "buttonThird")
            {
                model.Result = Math.Round(model.SquareSide * Math.Sqrt(2), 2);
                ViewBag.ResultDiagonal = model.Result.ToString();
            }
            if (button == "buttonFourth")
            {
                model.Result = model.SquareSide * 4;
                ViewBag.ResultCircuit = model.Result.ToString();
            }

            return View();
        }


        [HttpGet]
        public IActionResult Rectangle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Rectangle(VariablesModel model, string button)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (button == "buttonFirst")
            {
                model.Result = Math.Sqrt(Math.Pow(model.RectangleDiagonal, 2) - Math.Pow(model.SecondRectangleSide, 2));
                ViewBag.ResultSecondSide = model.Result.ToString();
            }
            if (button == "buttonSecond")
            {
                model.Result = Math.Sqrt(Math.Pow(model.RectangleDiagonal, 2) - Math.Pow(model.FristRectangleSide, 2));
                ViewBag.ResultFirstSide = model.Result.ToString();
            }
            if (button == "buttonThird")
            {
                model.Result = Math.Sqrt(Math.Pow(model.FristRectangleSide, 2) + Math.Pow(model.SecondRectangleSide, 2));
                ViewBag.ResultDiagonal = model.Result.ToString();
            }
            if (button == "buttonFourth")
            {
                model.Result = model.FristRectangleSide * model.SecondRectangleSide;
                ViewBag.ResultArea = model.Result.ToString();
            }
            if (button == "buttonFifth")
            {
                model.Result = (2 * model.FristRectangleSide) + (2 * model.SecondRectangleSide);
                ViewBag.ResultCircuit = model.Result.ToString();
            }

            return View();
        }
        [HttpGet]
        public IActionResult Triangle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Triangle(VariablesModel model, string button)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (button == "buttonFirst") 
            {
                model.Result = Math.Round((model.TriangleBaseLine * model.TriangleHeight) / 2, 2);
                ViewBag.ResultArea = model.Result.ToString();
            }
            if (button == "buttonSecond")
            {
                model.Result = Math.Round(((model.FirstTriangleSide * model.SecondTriangleSide) * Math.Sin(model.AlphaAngle)) /2 , 2);
                ViewBag.ResultArea2 = model.Result.ToString();
            }
            if (button == "buttonThird")
            {
                double halfCircle = (model.FirstTriangleSide + model.SecondTriangleSide + model.TriangleBaseLine) / 2;
                model.Result = Math.Round(Math.Sqrt(halfCircle * (halfCircle - model.FirstTriangleSide) * (halfCircle - model.SecondTriangleSide) * (halfCircle - model.TriangleBaseLine)), 2);
                ViewBag.ResultArea3 = model.Result.ToString();
            }
            if (button == "buttonFourth")
            {
                model.Result = Math.Round(Math.Sqrt(Math.Pow(model.FirstCathetus, 2) + Math.Pow(model.SecondCathetus, 2)), 2);
                ViewBag.ResultHypnotenuse = model.Result.ToString();
            }
            if (button == "buttonFifth")
            {
                model.Result = Math.Round(Math.Sqrt(Math.Pow(model.Hypotenuse, 2) - Math.Pow(model.SecondCathetus, 2)), 2);
                ViewBag.ResultFirstCatheus = model.Result.ToString();
            }
            if (button == "buttonSixth")
            {
                model.Result = Math.Round(Math.Sqrt(Math.Pow(model.Hypotenuse, 2) - Math.Pow(model.FirstCathetus, 2)), 2);
                ViewBag.ResultSecondCatheus = model.Result.ToString();
            }
            if (button == "buttonSeventh")
            {
                model.Result = Math.Round(model.TriangleBaseLine + model.FirstTriangleSide + model.SecondTriangleSide , 2);
                ViewBag.ResultCircuit = model.Result.ToString();
            }



            return View();
        }
    }
}
