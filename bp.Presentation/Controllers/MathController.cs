using bp.Application.Interfaces;
using bp.Application.UseCases.Math;
using Microsoft.AspNetCore.Mvc;
using static bp.Application.UseCases.Math.AddTwoNumbers;

namespace bp.Presentation.Controllers
{
    public class MathController : Controller
    {
        private readonly IUseCase<AddTwoNumbersInput, int> _addTwoNumbersUseCase;

        public MathController(IUseCase<AddTwoNumbersInput, int> addTwoNumbersUseCase)
        {
            _addTwoNumbersUseCase = addTwoNumbersUseCase;
        }

        [HttpGet("AddTwoNumbers/{number1}-{number2}")]
        public IActionResult AddTwoNumbers(int number1, int number2)
        {
            var input = new AddTwoNumbersInput(number1, number2);
            return Ok(_addTwoNumbersUseCase.execute(input));
        }
    }
}
