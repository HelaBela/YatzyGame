using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class CategoryProvider
    {
        public List<ICategory> GetCategories(List<ICategory> usedCategories)
        {
            List<ICategory> availableCategories = new List<ICategory>();

            if (!usedCategories.OfType<PairCategory>().Any())
            {
                availableCategories.Add(new PairCategory());
            }

            if (!usedCategories.OfType<YatzyCategory>().Any())
            {
                availableCategories.Add(new YatzyCategory());
            }

            if (!usedCategories.OfType<TwoPairsCategory>().Any())
            {
                availableCategories.Add(new TwoPairsCategory());
            }

            if (!usedCategories.OfType<ChanceCategory>().Any())
            {
                availableCategories.Add(new ChanceCategory());
            }

            if (!usedCategories.OfType<LargeStraightCategory>().Any())
            {
                availableCategories.Add(new LargeStraightCategory());
            }

            if (!usedCategories.OfType<SmallStraightCategory>().Any())
            {
                availableCategories.Add(new SmallStraightCategory());
            }

            if (!usedCategories.OfType<FullHouseCategory>().Any())
            {
                availableCategories.Add(new FullHouseCategory());
            }

            if (!usedCategories.OfType<ThreeOfAKindCategory>().Any())
            {
                availableCategories.Add(new ThreeOfAKindCategory());
            }


            return availableCategories;
        }
    }
}