using System;
using System.Collections.Generic;

namespace yatzy
{
    public class ThreeOfAKindCategory : ICategory

    {
        public string Name { get; }

        public int CalculateScore(List<int> finalDiceNumbers)
        {
            if (finalDiceNumbers == null)
            {
                throw new ArgumentNullException(nameof(finalDiceNumbers));
            }

//            var pair = finalDiceNumbers.GroupBy(x => x)
//                .Where(s => s.Count() > 1)
//                .OrderByDescending(o=> o.Key)
//                .FirstOrDefault()?.Key;
//
//            if (pair != null)
//            {
//                return pair.Value * 2;
//            }

            return 0;
        }
    }
}