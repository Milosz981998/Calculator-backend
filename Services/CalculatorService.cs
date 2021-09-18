﻿using Calculator.Data;
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

        private float Add(float firstNumber,float secondNumber)
        {
            return firstNumber + secondNumber;
        }  
        private float Subtract(float firstNumber,float secondNumber)
        {
            return firstNumber - secondNumber;
        }   
        private float Divide(float firstNumber,float secondNumber)
        {
            if(secondNumber == 0)
            {
                throw new DivideByZeroException();
            }
            return firstNumber / secondNumber;
        }
        private float Multiply(float firstNumber,float secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public float SetResult(CalculatorCreate calculatorCreateDto)
        {
            string sign = calculatorCreateDto.Sign;
            float firstNumber = calculatorCreateDto.FirstNumber;
            float secondNumber = calculatorCreateDto.SecondNumber;
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
                Sign = sign
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