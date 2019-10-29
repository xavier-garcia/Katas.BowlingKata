using System;
using Xunit;

namespace BowlingKata
{
    public class ScoreCalculatorShould
    {
        [Fact]
        public void Be_Zero_When_All_Frames_Are_Zero()
        {
            //Arrange
            const double expected = 0;
            int[] frames = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};


            //Act
            double result = new ScoreCalculator().Calculate(frames);


            //Assert
            Assert.Equal(expected, result);
        }
    }
}
