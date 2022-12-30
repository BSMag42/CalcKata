using CalcKata;

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
            var result = sut.Add("","");
            //result
            Assert.Equal(0,result);
        }

        [Fact]
        public void Returns_Sum_of_Two_Numbers()
        {
            var sut = new StringCalculator();
            var result = sut.Add("3", "2");
            Assert.Equal(5,result);
        }

    }
}