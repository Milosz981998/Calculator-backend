using AutoMapper;
using Calculator.Dtos;
using Calculator.Models;
namespace Calculator.Profiles
{
    public class CalculatorProfile : Profile
    {
        public CalculatorProfile()
        {
            CreateMap<CalculatorCreateDto, CalculatorCreate>();
        }
    }
}
