using Packt;
using Xunit;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void TestAdding2And2()
        {
            // arrange
            double a = 2.0;
            double b = 2.0;
            double expected = 4.0;

            var  calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            // arrange
            double a = 2.0;
            double b = 3.0;
            double expected = 5.0;

            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
