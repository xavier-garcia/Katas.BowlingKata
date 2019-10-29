namespace BowlingKata
{
    internal class ScoreCalculator
    {
        public ScoreCalculator()
        {
        }

        public int Calculate(int[] turns)
        {
            int score = 0;
            foreach (var turn in turns)
            {
                score += turn;
            }

            return score;
        }

    }
}