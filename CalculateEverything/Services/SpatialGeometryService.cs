using CalculateEverything.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEverything.Services
{
    public interface ISpatialGeometryService
    {
        void CubeArea(SpatialGeometryModel model);
    }

    public class SpatialGeometryService : ISpatialGeometryService
    {
        private readonly SpatialGeometryModel _model;
        

        public SpatialGeometryService(SpatialGeometryModel model)
        {
            _model = model;
            
        }

        public void CubeArea(SpatialGeometryModel model)
        {
            model.Result = Math.Round(6 * Math.Pow(model.CubeSide, 2 ), 2);           
        }
    }
}
