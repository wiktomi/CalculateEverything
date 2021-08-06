using System.ComponentModel.DataAnnotations;

namespace CalculateEverything.Models
{
    public class VariablesModel
    {
        // Kwadrat

        [Display(Name = "Bok kwadratu")]
        [Required(ErrorMessage = "Pole Wymagane")]
        public double SquareSide { get; set; }

        [Display(Name = "Przekątna kwadratu")]
        [Required]
        public double SquareDiagonal { get; set; }

        // Prostokąt

        [Display(Name = "Pierwszy bok prostokąta")]
        public double FristRectangleSide { get; set; }

        [Display(Name = "Drugi bok prostokąta")]
        public double SecondRectangleSide { get; set; }
        [Display(Name = "Przekątna prostokąta")]
        public double RectangleDiagonal { get; set; }

        // Trójkąt

        [Display(Name = "Podstawa trójkąta")]
        public double TriangleBaseLine { get; set; }

        [Display(Name = "Pierwszy bok trójkąta")]
        public double FirstTriangleSide { get; set; }

        [Display(Name = "Drugi bok trójkąta")]
        public double SecondTriandleSide { get; set; }

        [Display(Name = "Wysokość trójkąta")]
        public double TriangleHeight { get; set; }

        [Display(Name ="Pierwsza przyprostokątna")]
        public double FirstCathetus { get; set; }

        [Display(Name ="Druga przyprostokątna")]
        public double SecondCathetus { get; set; }

        [Display(Name ="Przeciwprostokątna")]
        public double Hypotenuse { get; set; }


        [Display(Name = "Wynik")]
        public double Result { get; set; }
    }
}
