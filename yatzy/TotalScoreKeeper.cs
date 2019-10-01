using System.Collections.Generic;

namespace yatzy
{
    public class TotalScoreKeeper
    {
        List<ICategory> categories = new List<ICategory>();
        TotalScoreKeeper()
        {
            categories = new List<ICategory>()
            {
                new YatzyCategory(), new PairCategory(), new TwoPairsCategory()
            };
        }

        public void KeepingTrackOfCategoriesUsed()
        {
            List<ICategory> usedCategories = new List<ICategory>();
            
           // usedCategories.Add();
        }

    }
}