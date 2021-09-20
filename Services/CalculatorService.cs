using Calculator.Data;
using Calculator.Dtos;
using Calculator.Exceptions;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class CalculatorService : Service, ICalculatorService
    {
        
        public CalculatorService(CalculatorDbContext dbContext) : base(dbContext)
        {
            
        }
        public List<History> GetHistory()
        {
            return _calculatorDbContext.History.ToList();
        }

        private decimal Add(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }  
        private decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }   
        private decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            if(secondNumber == 0)
            {
                throw new DivideByZeroException();
            }
            return firstNumber / secondNumber;
        }
        private decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public decimal SetResult(CalculatorCreate calculatorCreateDto)
        {
            string sign = calculatorCreateDto.Sign;
            decimal firstNumber = calculatorCreateDto.FirstNumber;
            decimal secondNumber = calculatorCreateDto.SecondNumber;
            var result = sign switch
            {
                "+" => Add(firstNumber,secondNumber),
                "-" => Subtract(firstNumber, secondNumber),
                "/" => Divide(firstNumber, secondNumber),
                "*" => Multiply(firstNumber, secondNumber),
                _ => throw new UndefinedSignException(),
            };
            SetHistory(new History()
            {
                FirstNumber = firstNumber,
                SecondNumber = secondNumber,
                Sign = sign,
                Result = result
            });

            return result;
        }
        private void SetHistory(History history)
        {
            history.CreatedAt = DateTime.Now;
            _calculatorDbContext.Add(history);
            _calculatorDbContext.SaveChanges();
        }

    }
}
