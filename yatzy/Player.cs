using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace yatzy
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; private set; }

        private readonly IConsoleService _iConsoleService;

        public Player(string name, IConsoleService iConsoleService)
        {
            Name = name;
            _iConsoleService = iConsoleService;
        }

        public void UpdateScore(int score)
        {
            Score = score;

            //"this is your final score... "
        }

        public List<int> Hold(List<int> rollResults)
        {
            DisplayDice(rollResults);
            _iConsoleService.Write(
                "choose index number 0-5 of numbers you want to hold separated with a coma"); 

            var numbersToHold = new List<int>();

            var userAnswer = _iConsoleService.Read();

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

            _iConsoleService.Write("choose which category you want to use to count your score: ");

            for (int i = 0; i < availableCategories.Count; i++)
            {
                _iConsoleService.Write($"{i}: {availableCategories[i].Name}");
            }
            
            ICategory category = null;
            while (category == null)
            {
                var userChoice = int.Parse(_iConsoleService.Read());
                if (userChoice >= 0 && userChoice < availableCategories.Count)
                {
                    category = availableCategories[userChoice];
                }
                else
                {
                    _iConsoleService.Write("Wrong choice. Try again.");
                }
            }
            
            return category;
        }


        public void DisplayDice(List<int> rollResults)
        {
            _iConsoleService.Write("Here are your numbers: ");

            foreach (var number in rollResults)
            {
                _iConsoleService.Write($"{number}");
            }
        }
    }
}