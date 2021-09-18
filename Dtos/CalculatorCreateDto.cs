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
        [Range(float.MinValue,float.MaxValue)]
        public float? FirstNumber { get; set; }
        [Required]
        [AssertThat("Sign == '+' || Sign == '-' || Sign == '/' || Sign == '*'",ErrorMessage = "Available signs is +,-,/,*")]
        public string Sign { get; set; }
        [Required]
        [Range(float.MinValue, float.MaxValue)]
        public float? SecondNumber { get; set; }
    }
}
