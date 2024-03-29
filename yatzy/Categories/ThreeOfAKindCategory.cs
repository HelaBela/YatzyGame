using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class ThreeOfAKindCategory : ICategory

    {
        public string Name => "Three of a Kind";

        public int CalculateScore(List<int> finalDiceNumbers)
        {
            if (finalDiceNumbers == null)
            {
                throw new ArgumentNullException(nameof(finalDiceNumbers));
            }

            var three = finalDiceNumbers.GroupBy((x => x))
                .Where(s => s.Count() > 2)
                .OrderByDescending((o => o.Key))
                .FirstOrDefault()?.Key;

            if (three != null)
            {
                return three.Value *3;
            }
            

            return 0;
        }
    }
}