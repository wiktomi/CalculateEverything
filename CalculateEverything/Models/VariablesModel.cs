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
        public double SecondTriangleSide { get; set; }

        [Display(Name = "Wysokość trójkąta")]
        public double TriangleHeight { get; set; }

        [Display(Name = "Kąt alfa")]
        public int AlphaAngle { get; set; }

        [Display(Name ="Pierwsza przyprostokątna")]
        public double FirstCathetus { get; set; }

        [Display(Name ="Druga przyprostokątna")]
        public double SecondCathetus { get; set; }

        [Display(Name ="Przeciwprostokątna")]
        public double Hypotenuse { get; set; }

        // Równoległobok

        [Display(Name = "Pierwszy bok równoległoboku")]
        public double FirstSideParallerogram { get; set; }

        [Display(Name = "Drugi bok równoległoboku")]
        public double SecondSideParallerogram { get; set; }

        [Display(Name = "Wysokość równoległoboku")]
        public double HeightParallerogram { get; set; }

        [Display(Name = "Pierwsza przekątna równoległoboku")]
        public double FirstDiagonalParallerogram { get; set; }

        [Display(Name = "Druga przekątna równoległoboku")]
        public double SecondDiagonalParallerogram { get; set; }

        [Display(Name = "Kąt alfa równoległoboku")]
        public int AlphaAngleParallerogram { get; set; }

        [Display(Name = "Kąt gamma równoległoboku")]
        public int GammaAngleParallerogram { get; set; }

        //Romb i deltoid

        [Display(Name = "Bok rombu")]
        public double RhombusSide { get; set; }
        [Display(Name = "Wysokość rombu")]
        public double RhombusHeight { get; set; }
        [Display(Name = "Kąt alfa")]
        public int RhombusAlfaAngle { get; set; }
        [Display(Name = "Pierwsza przekątna rombu")]
        public double FirstRhombusDiagonal { get; set; }
        [Display(Name = "Druga przekątna rombu")]
        public double SecondRhombusDiagonal { get; set; }
        [Display(Name = "Pierwsza przekątna deltoidu")]
        public double FirstDeltoidDiagonal { get; set; }
        [Display(Name = "Druga przekątna rombu")]
        public double SecondDeltoidDiagonal { get; set; }
        [Display(Name = "Pierwszy bok deltoidu")]
        public double FirstDeltoidSide { get; set; }
        [Display(Name = "Drugi bok deltoidu")]
        public double SecondDeltoidSide { get; set; }
        [Display(Name = "Kąt alfa deltoidu")]
        public int DeltoidAlphaAngle { get; set; }

        //Trapez

        [Display(Name = "Dolna podstawa trapezu")]
        public double TrapeziumDownBase { get; set; }
        [Display(Name = "Górna podstawa trapezu")]
        public double TrapeziumUpBase { get; set; }
        [Display(Name = "Pierwszy bok trapezu")]
        public double TrapeziumFirstSide { get; set; }
        [Display(Name = "Drugi bok trapezu")]
        public double TrapeziumSecondSide { get; set; }
        [Display(Name = "Wysokość trapezu")]
        public double TrapeziumHeight { get; set; }



        [Display(Name = "Wynik")]
        public double Result { get; set; }
    }
}
