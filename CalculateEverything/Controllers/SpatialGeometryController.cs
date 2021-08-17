using CalculateEverything.Models;
using CalculateEverything.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEverything.Controllers
{
    public class SpatialGeometryController : Controller
    {
        private readonly ISpatialGeometryService _spatialGeometry;

        public SpatialGeometryController(ISpatialGeometryService spatialGeometry)
        {
            _spatialGeometry = spatialGeometry;
        }

        [HttpGet]
        public ActionResult Cube()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cube(SpatialGeometryModel model)
        {
            _spatialGeometry.CubeArea(model);
            return View();
        }
    }
}

