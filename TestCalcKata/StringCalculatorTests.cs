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
            var result = sut.Add("");

            //result
            Assert.Equal(0,result);
        }


    }
}