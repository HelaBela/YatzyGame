using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class TwoPairsCategory : ICategory
    {
        public string Name => "Two Pairs";

        public int CalculateScore(List<int> finalDiceNumbers)
        {
            var result = 0;

            if (finalDiceNumbers == null)
            {
                throw new ArgumentNullException(nameof(finalDiceNumbers));
            }

            var pair = finalDiceNumbers.GroupBy(x => x)
                .Where(s => s.Count() > 1).Select(y => y.Key).ToList();

            var fours = finalDiceNumbers.GroupBy(x => x).Where(s => s.Count() > 3).Select(y => y.Key).ToList();

            if (fours.Count>0)
            {
                foreach (var number in fours)
                {
                    result = 2 * (number + number);
                }

                return result;

            }


            if (pair.Count > 1)
            {
                foreach (var number in pair)
                {
                    result += number + number;
                }

                return result;
            }

            return 0;
        }
    }
}