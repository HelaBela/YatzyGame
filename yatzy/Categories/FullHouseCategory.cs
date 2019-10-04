using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class FullHouseCategory : ICategory
    {
        public string Name => "Full House";

        public int CalculateScore(List<int> finalDiceNumbers)
        {
            if (finalDiceNumbers == null)
            {
                throw new ArgumentNullException(nameof(finalDiceNumbers));
            }

            var pair = finalDiceNumbers.GroupBy(x => x)
                .Where(s => s.Count() == 2)
                .OrderByDescending(o => o.Key)
                .FirstOrDefault()?.Key;

            var threeOfAKind = finalDiceNumbers.GroupBy((x => x))
                .Where(s => s.Count() == 3)
                .OrderByDescending((o => o.Key))
                .FirstOrDefault()?.Key;


            if (pair != null && threeOfAKind != null)
            {
                return finalDiceNumbers.Sum();
            }


            return 0;
        }
    }
}