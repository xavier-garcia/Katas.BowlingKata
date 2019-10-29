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


        [Theory]
        [InlineData(new int[]{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 20)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2}, 21)]
        [InlineData(new int[] { 3, 1, 3, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2}, 27)]

        public void Sum_All_Turns(int[] turns, int expected)
        {
            //Arrange

            //Act
            int result = new ScoreCalculator().Calculate(turns);


            //Assert
            Assert.Equal(expected, result);
        }
    }
}
