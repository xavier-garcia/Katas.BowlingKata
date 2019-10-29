using System;
using Xunit;

namespace BowlingKata
{
    public class ScoreCalculatorShould
    {
        [Fact]
        public void Be_Zero_When_All_Turns_Are_Zero()
        {
            //Arrange
            const double expected = 0;
            int[] frames = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};


            //Act
            double result = new ScoreCalculator().Calculate(frames);


            //Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Sum_All_Turns()
        {
            //Arrange
            const int expected = 20;
            int[] frames = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };


            //Act
            int result = new ScoreCalculator().Calculate(frames);


            //Assert
            Assert.Equal(expected, result);
        }
    }
}
