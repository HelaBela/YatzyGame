using System.Collections.Generic;

namespace yatzy
{
    public interface ICategory
    {
        int CalculateScore(List<int> finalDiceNumbers);
    }
}