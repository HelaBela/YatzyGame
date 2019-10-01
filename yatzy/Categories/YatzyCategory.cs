using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class YatzyCategory : ICategory
    {
        public string Name => "Yatzy";

        public int CalculateScore(List<int> finalDiceNumbers)
        {
            if (finalDiceNumbers == null)
            {
                throw new Exception("There are no dice numbers to work with");
            }

            var numberOfDice = finalDiceNumbers.Distinct().Count();

            if (numberOfDice == 1)
                return 50;

            return 0;
        }
    }
}