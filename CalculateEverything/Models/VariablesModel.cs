using System.ComponentModel.DataAnnotations;

namespace CalculateEverything.Models
{
    public class VariablesModel
    {
        [Display(Name = "Bok kwadratu")]
        public double SquareSide { get; set; }

        [Display(Name = "Pierwszy bok prostokąta")]
        public double FristRectangleSide { get; set; }

        [Display(Name = "Drugi bok prostokąta")]
        public double SecondRectangleSide { get; set; }

        [Display(Name = "Podstawa trójkąta")]
        public double TriangleBaseLine { get; set; }

        [Display(Name = "Wysokość trójkąta")]
        public double TriangleHeight { get; set; }


        [Display(Name = "Wynik")]
        public double Result { get; set; }
    }
}
