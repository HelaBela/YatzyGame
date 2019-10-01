using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public void UpdateScore(int score)
        {
            Score = score;

            //"this is your final score... "
        }

        public List<int> Hold(List<int> rollResults)
        {
            DisplayDice(rollResults);
            Console.WriteLine(
                "choose index number 0-5 of numbers you want to hold separated with a coma"); //use IOservice instead of Console.Write.

            var numbersToHold = new List<int>();

            var userAnswer = Console.ReadLine();

            List<string> choosenNumbersToHold = userAnswer.Split(",").ToList();

            foreach (var number in choosenNumbersToHold)
            {
                numbersToHold.Add(int.Parse(number));
            }

            return numbersToHold;
        }


        public ICategory ChooseCategory(List<ICategory> availableCategories, List<int> rolledDice)
        {
            DisplayDice(rolledDice);

            Console.WriteLine("choose which category you want to use to count your score: ");

            for (int i = 0; i < availableCategories.Count; i++)
            {
                Console.WriteLine($"{i}: {availableCategories[i].Name}");
            }
            
            ICategory category = null;
            while (category == null)
            {
                var userChoice = int.Parse(Console.ReadLine());
                if (userChoice >= 0 && userChoice < availableCategories.Count)
                {
                    category = availableCategories[userChoice];
                }
                else
                {
                    Console.WriteLine("Wrong choice. Try again.");
                }
            }
            
            return category;
        }


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