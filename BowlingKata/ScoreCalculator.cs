using System;
using System.Collections.Generic;

namespace BowlingKata
{
    internal class ScoreCalculator
    {
        public ScoreCalculator()
        {
        }

        public int Calculate(int[] tries)
        {
            int score = 0;
            bool strike = false;

            var turn = new int[10, 2];

            int turno = 0;
            int bola = 0;

            List<int[]> arrayList = new List<int[]>
            {
                new int[] { }
               
            };

            var torn = new int[2];

            foreach (var @try in tries)
            {
                

                torn[bola] = @try;

                if (bola == 1 || @try == 10)
                {
                    arrayList.Add(torn);
                    bola = 0;
                }

                bola++;
            }


        foreach (var @try in tries)
            {
                if(@try != 10)


               


                score += @try;

                //if (strike)
                //{
                //    score += @try;

                //    if (turnTries == 2)
                //    {
                //        strike = false;

                //    }
                //}

                //if (@try == 10)
                //{
                //    strike = true;
                //    //turnFinished = true;
                //    turnTries = 0;

                //}

                //if (turnTries == 2)
                //{
                //    turnTries = 0;
                //}


            }

            return score;
        }

    }
}