using bp.Application.UseCases.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bp.Application.UseCases.Math.AddTwoNumbers;

namespace bp.Tests.Application.UseCases.Math
{
    public class AddApplicationServicesTests
    {
        private readonly AddTwoNumbers _useCase;

        public AddApplicationServicesTests()
        {
            _useCase = new();
        }

        [Theory]
        [InlineData(-1,1,0)]
        [InlineData(0,1,1)]
        [InlineData(0,0,0)]
        [InlineData(-1,-1,-2)]
        public void NumbersAreAddedCorrectly_ExecuteAsync_CorrectSum (int a, int b, int expected)
        {
            var input = new AddTwoNumbersInput(a, b);
            var actual = _useCase.execute(input);

            Assert.Equal(expected, actual);
        }
    }
}
