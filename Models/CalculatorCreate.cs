﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class CalculatorCreate
    {
        public decimal FirstNumber { get; set; }
        public string Sign { get; set; }
        public decimal SecondNumber { get; set; }
    }
}
