using Calculator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public abstract class Service
    {
        protected readonly CalculatorDbContext _calculatorDbContext;
        public Service(CalculatorDbContext dbContext)
        {
            _calculatorDbContext = dbContext;
        }
    }
}
