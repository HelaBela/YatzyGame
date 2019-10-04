using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class ChanceCategory:ICategory
    {
        public string Name => "Chance";
        public int CalculateScore(List<int> finalDiceNumbers)
        {
            if (finalDiceNumbers == null)
            {
                throw new ArgumentNullException(nameof(finalDiceNumbers));
            }

            return finalDiceNumbers.Sum(s => s);
        }
    }
}