using CalcKata;
using Xunit;

namespace TestCalcKata
{
    public class StringCalculatorTests
    {

        [Fact]
        public void Returns_Zero_When_Empty_String()
        {
            //arrange
            var sut = new StringCalculator();
            //act
            var result = sut.Add("");
            //result
            Assert.Equal(0,result);
        }

        [Fact]
        public void Returns_Sum_of_Two_Numbers()
        {
            var sut = new StringCalculator();
            var result = sut.Add("3,2");
            Assert.Equal(5,result);
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("3,2", 5)]
        [InlineData("10,100,1000", 1110)]
        public void Returns_Sum_When_Any_Number_Of_Params_Given(string calcInputs, int expected)
        {
            var sut = new StringCalculator();
            var result = sut.Add(calcInputs);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        public void Returns_Sum_With_NewLine_Delimiter(string calcInputs, int expected)
        {
            var sut = new StringCalculator();
            var result = sut.Add(calcInputs);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("//;\n1;3", 4)]
        [InlineData("//;\n1;3;5", 9)]
        public void Returns_Sum_With_Any_Delimiter(string calcInputs, int expected)
        {
            var sut = new StringCalculator();
            var result = sut.Add(calcInputs);
            Assert.Equal(expected, result);
        }
    }
}