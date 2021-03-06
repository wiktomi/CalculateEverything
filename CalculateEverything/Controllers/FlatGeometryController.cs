using CalculateEverything.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculateEverything.Controllers
{
    public class FlatGeometryController : Controller
    {
        private readonly FlatGeometryModel _model;

        public FlatGeometryController(FlatGeometryModel model)
        {
            _model = model;
        }
        [HttpGet]
        public IActionResult Square()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Square(FlatGeometryModel model, string button)
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
        public IActionResult Rectangle(FlatGeometryModel model, string button)
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
        public IActionResult Triangle(FlatGeometryModel model, string button)
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
                model.Result = Math.Round(((model.FirstTriangleSide * model.SecondTriangleSide) * Math.Sin(model.AlphaAngle)) / 2, 2);
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
                model.Result = Math.Round(model.TriangleBaseLine + model.FirstTriangleSide + model.SecondTriangleSide, 2);
                ViewBag.ResultCircuit = model.Result.ToString();
            }
            return View();

        }

        [HttpGet]
        public IActionResult Parallelogram()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Parallelogram(FlatGeometryModel model, string button)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (button == "buttonFirst")
            {
                model.Result = Math.Round((model.FirstSideParallerogram * model.HeightParallerogram), 2);
                ViewBag.ResultArea = model.Result.ToString();
            }
            if (button == "buttonSecond")
            {
                model.Result = Math.Round(model.FirstSideParallerogram * model.SecondSideParallerogram * Math.Sin(model.AlphaAngleParallerogram * (Math.PI/180)), 2);
                ViewBag.ResultArea2 = model.Result.ToString();
            }
            if (button == "buttonThird")
            {
                model.Result = Math.Round(((model.FirstDiagonalParallerogram * model.SecondDiagonalParallerogram) / 2 ) * Math.Sin(model.GammaAngleParallerogram), 2);
                ViewBag.ResultArea3 = model.Result.ToString();
            }
            if (button == "buttonFourth")
            {
                model.Result = Math.Round((model.FirstSideParallerogram * 2) + (model.SecondSideParallerogram *2), 2);
                ViewBag.ResultCircuit = model.Result.ToString();
            }

            return View();
        }
        [HttpGet]
        public IActionResult RhombusAndDeltoid()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RhombusAndDeltoid(FlatGeometryModel model, string button)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (button == "buttonFirst")
            {
                model.Result = Math.Round((model.RhombusSide * model.RhombusHeight), 2);
                ViewBag.ResultArea = model.Result.ToString();
            }
            if (button == "buttonSecond")
            {
                model.Result = Math.Round(model.RhombusSide * Math.Sin(model.RhombusAlfaAngle * (Math.PI / 180)), 2);
                ViewBag.ResultArea2 = model.Result.ToString();
            }
            if (button == "buttonThird")
            {
                model.Result = Math.Round((model.FirstRhombusDiagonal * model.SecondRhombusDiagonal) / 2 , 2);
                ViewBag.ResultArea3 = model.Result.ToString();
            }
            if (button == "buttonFourth")
            {
                model.Result = Math.Round(4 * model.RhombusSide , 2);
                ViewBag.ResultCircuit = model.Result.ToString();
            }
            if (button == "buttonFifth")
            {
                model.Result = Math.Round(model.FirstDeltoidDiagonal * model.SecondDeltoidDiagonal / 2, 2);
                ViewBag.ResultAreaDeltoid = model.Result.ToString();
            }
            if (button == "buttonSixth")
            {
                model.Result = Math.Round(model.FirstDeltoidSide * model.SecondDeltoidSide * Math.Sin(model.DeltoidAlphaAngle * (Math.PI / 180)), 2);
                ViewBag.ResultAreaDeltoid2 = model.Result.ToString();
            }
            if (button == "buttonSeventh")
            {
                model.Result = Math.Round(2 * model.FirstDeltoidSide + 2 * model.SecondDeltoidSide, 2);
                ViewBag.ResultDeltoidCircuit = model.Result.ToString();
            }

            return View();
        }
        [HttpGet]
        public IActionResult Trapezium()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Trapezium(FlatGeometryModel model, string button)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (button == "buttonFirst")
            {
                model.Result = Math.Round((model.TrapeziumDownBase + model.TrapeziumUpBase) / 2 * model.TrapeziumHeight, 2);
                ViewBag.ResultArea = model.Result.ToString();
            }
            if (button == "buttonSecond")
            {
                model.Result = Math.Round(model.TrapeziumDownBase + model.TrapeziumUpBase + model.TrapeziumFirstSide + model.TrapeziumSecondSide, 2);
                ViewBag.ResultCircuit = model.Result.ToString();
            }

            return View();
        }
        [HttpGet]
        public IActionResult Circle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Circle(FlatGeometryModel model, string button)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (button == "buttonFirst")
            {
                model.Result = Math.Round(Math.PI * Math.Pow(model.CircleRadius, 2), 2);
                ViewBag.ResultArea = model.Result.ToString();
            }
            if (button == "buttonSecond")
            {
                model.Result = Math.Round(2* Math.PI * model.CircleRadius, 2);
                ViewBag.ResultCircuit = model.Result.ToString();
            }

            return View();
        }
        
    }
}
