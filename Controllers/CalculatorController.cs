using AutoMapper;
using Calculator.Data;
using Calculator.Dtos;
using Calculator.Exceptions;
using Calculator.Models;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
       
        private readonly ICalculatorService _calculatorService;
        private readonly IMapper _mapper;

        public CalculatorController(ICalculatorService calculatorService, IMapper mapper)
        {
            _calculatorService = calculatorService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_calculatorService.GetHistory());
        }  
        [HttpPost]
        public ActionResult SetResult([FromBody]CalculatorCreateDto calculatorCreateDto)
        {
            try
            {
                var calculatorCreate = new CalculatorCreate();
                _mapper.Map(calculatorCreateDto, calculatorCreate);
                return Ok(_calculatorService.SetResult(calculatorCreate));
            }
            catch (DivideByZeroException e)
            {
                return StatusCode(400, new { errors = new { SecondNumber = e.Message }, title = "DivideByZero" });
            }
            catch (Exception)
            {
                return StatusCode(500, "Undefined error");
            }
        }
    }
}
