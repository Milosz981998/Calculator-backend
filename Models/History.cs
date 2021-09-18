using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class History
    {
        public long Id { get; set; }
        public float FirstNumber { get; set; }
        public string Sign { get; set; }
        public float SecondNumber { get; set; }
        public float Result { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
