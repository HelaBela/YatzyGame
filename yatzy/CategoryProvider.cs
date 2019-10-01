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


            return availableCategories;
        }
    }
}