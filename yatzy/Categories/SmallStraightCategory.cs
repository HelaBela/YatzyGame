using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class SmallStraightCategory : ICategory
    {
        public string Name => "Small Straight";
        public int CalculateScore(List<int> finalDiceNumbers)
        {
            if (finalDiceNumbers == null)
            {
                throw new ArgumentNullException(nameof(finalDiceNumbers));
            }

            var smallStraight = new List<int>() {1, 2, 3, 4, 5};

            var checkIfFinalDiceIsASmallStraight = finalDiceNumbers.SequenceEqual(smallStraight);

            if (checkIfFinalDiceIsASmallStraight)
            {
                return finalDiceNumbers.Sum();
            }
            
            return 0;
        }
    }
}