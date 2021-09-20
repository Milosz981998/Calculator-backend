using Calculator.Dtos;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public interface ICalculatorService
    {
        List<History> GetHistory();
        decimal SetResult(CalculatorCreate calculatorCreateDto);
    }
}
