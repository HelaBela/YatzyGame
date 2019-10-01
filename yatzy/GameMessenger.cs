using System;
using System.Collections.Generic;

namespace yatzy
{
    public class GameMessenger
    {
        public void DisplayDice(List<int> rollResults) //I might not need this class. In the future , more advanced way
        //would be to make this a middle men between game and player
        {
            Console.WriteLine("Here are your numbers: ");

            foreach (var number in rollResults)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}