using System;
using Xunit;

namespace TestingSuperbowlNames
{
    public class testing_user_input
    {

        [Fact]
        public void one_should_be_I()
        {
            //Arrange --context
            var romanCalc = new RomanNumeralEngine();
            var input = "1";
            var expectedResult = "I";

            //Act -- do the thing
            var actualResult = romanCalc.Translate(input);


            //Assert -- checking the result
            Assert.Equal(expectedResult, actualResult);


        }

        [Fact]
        public void two_should_be_II()
        {
            //Arrange --context
            var romanCalc = new RomanNumeralEngine();
            var input = "2";
            var expectedResult = "II";

            //Act -- do the thing
            var actualResult = romanCalc.Translate(input);


            //Assert -- checking the result
            Assert.Equal(expectedResult, actualResult);


        }
    }
}
