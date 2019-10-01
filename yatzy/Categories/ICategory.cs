using System;
using System.Collections.Generic;

namespace yatzy
{
    public interface ICategory
    {

        string Name { get; }
        
        int CalculateScore(List<int> finalDiceNumbers);
    }
}