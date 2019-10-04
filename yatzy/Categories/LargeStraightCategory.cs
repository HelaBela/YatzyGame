using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class LargeStraightCategory:ICategory
    {
        public string Name => "Large Straight";
        public int CalculateScore(List<int> finalDiceNumbers)
        {
            if (finalDiceNumbers == null)
            {
                throw new ArgumentNullException(nameof(finalDiceNumbers));
            }
            
            var largeStraight = new List<int>(){2,3,4,5,6};

            var isItALargeStraight = finalDiceNumbers.SequenceEqual(largeStraight);

            if (isItALargeStraight)
            {
                return finalDiceNumbers.Sum();
            }

            return 0;

        }
    }
}