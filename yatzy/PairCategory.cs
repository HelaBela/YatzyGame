using System.Collections.Generic;

namespace yatzy
{
    public class PairCategory : ICategory
    {
        public int CalculateScore(List<int> finalDiceNumbers)
        {
           // finalDiceNumbers = Game.ResultListFromSecondRoll;
            int sum = 0;


//            for (int i = 1; i <= 6; i++)
//            {
//                int Count = 0;
//                for (int j = 0; j < 5; j++)
//                {
//                    if (finalDiceNumbers[j] == i)
//                        Count++;
//                }
//            }

            return 40;
        }
    }
}

