using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace Calculator.Dtos
{
    public class CalculatorCreateDto
    {
        [Required]
        [Range((double)decimal.MinValue, (double)decimal.MaxValue)]
        public decimal? FirstNumber { get; set; }
        [Required]
        [AssertThat("Sign == '+' || Sign == '-' || Sign == '/' || Sign == '*'",ErrorMessage = "Available signs is +,-,/,*")]
        public string Sign { get; set; }
        [Required]
        [Range((double)decimal.MinValue, (double)decimal.MaxValue)]
        public decimal? SecondNumber { get; set; }
    }
}
