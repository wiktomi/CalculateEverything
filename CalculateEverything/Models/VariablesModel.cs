﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEverything.Models
{
    public class VariablesModel
    {
        [Display(Name = "Bok kwadratu")]
        public double SquareSide { get; set; }
        [Display(Name = "Wynik")]
        public double Result { get; set; }
    }
}   
