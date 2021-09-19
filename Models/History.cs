using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class History
    {
        public long Id { get; set; }
        public double FirstNumber { get; set; }
        public string Sign { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
