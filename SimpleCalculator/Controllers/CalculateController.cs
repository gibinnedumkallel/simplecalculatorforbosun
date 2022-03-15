using Microsoft.AspNetCore.Mvc;
using SimpleCalculator.Service.Interfaces;

namespace SimpleCalculator.Controllers
{
    [Route("api/[controller]")]
    public class CalculateController : Controller
    {
        private readonly ICalculatorService _calculatorService;

        public CalculateController(ICalculatorService calculator)
        {
            _calculatorService = calculator;
        }            

        [HttpGet("Add")]         
        public double Add(double x1, double x2)
        {
            return _calculatorService.Add(x1, x2);
        }

        [HttpGet("Divide")]
         
        public double Divide(double x1, double x2)
        {
            return _calculatorService.Divide(x1, x2);
        }
        [HttpGet("Multiply")]
         
        public double Multiply(double x1, double x2)
        {
            return _calculatorService.Multiply(x1, x2);
        }
        [HttpGet("Subtract")]
        //[Route("Subtract")]
        public double Subtract(double x1, double x2)
        {
            return _calculatorService.Subtract(x1, x2);
        }
    }
}

