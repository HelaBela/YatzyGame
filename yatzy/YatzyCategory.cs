using System.Collections.Generic;

namespace yatzy
{
    public class YatzyCategory: ICategory
    {
        public int CalculateScore(List<int> finalDiceNumbers)
        {
          //  finalDiceNumbers = Game.ResultListFromSecondRoll;
            
            foreach (var number in finalDiceNumbers)
            {
                if (true)
                {
                    return 50;
                }

            }

            return 0;

        }
    }
}