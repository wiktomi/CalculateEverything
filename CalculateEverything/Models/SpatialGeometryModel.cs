using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CalculateEverything.Models
{
    public class SpatialGeometryModel
    {
        // Sześcian
        [Display(Name = "Bok sześcianu")]
        public double CubeSide { get; set; }





        // Wyniki
        [Display(Name = "Wynik")]
        public double Result { get; set; }
    }
}
