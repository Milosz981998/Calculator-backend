using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class History
    {
        public long Id { get; set; }
        public decimal FirstNumber { get; set; }
        public string Sign { get; set; }
        public decimal SecondNumber { get; set; }
        public decimal Result { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
