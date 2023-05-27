using bp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bp.Application.UseCases.Math.AddTwoNumbers;

namespace bp.Application.UseCases.Math
{
    public class AddTwoNumbers : IUseCase<AddTwoNumbersInput, int>
    {
        public int execute(AddTwoNumbersInput input)
        {
            return input.a + input.b;
        }

        public record AddTwoNumbersInput(int a, int b);
    }
}
