using System;
using System.Collections.Generic;

namespace yatzy
{
    public class GameMessenger
    {
        public void DisplayDice(List<int> rollResults)
        {
            Console.WriteLine("Here are your numbers: ");

            foreach (var number in rollResults)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}