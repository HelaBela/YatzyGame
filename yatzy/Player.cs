using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class Player
    {
        public string Name { get;  }
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
            Console.WriteLine("choose index number 0-5 of numbers you want to hold separated with a coma"); //use IOservice instead of Console.Write.

            var numbersToHold = new List<int>();

            var userAnswer = Console.ReadLine();

            List<string> choosenNumbersToHold = userAnswer.Split(",").ToList();

            foreach (var number in choosenNumbersToHold)
            {
                numbersToHold.Add(int.Parse(number));
            }

            return numbersToHold;
        }


        public ICategory ChooseCategory( List<ICategory> usedCategories, List<int> rolledDice)
        {
            // Console.Write(rolledDice); -> show the dice to user here from GameMessagnger and delete the class
            
            Console.WriteLine(
                "choose which category you want to use to count your score: " +
                "'1' for Yatzy" +
                "'2' for Pair Category" +
                "'3' for Two Pairs Category");
            
           

            var userChoice = int.Parse(Console.ReadLine());
            var yatzyCat = 1;
            var pairCat = 2;
            var twoPairsCat = 3;
            
           //if(Game.UsedCategories) ->make this a parameter
            

            if (userChoice == yatzyCat)
            {
                return new YatzyCategory();
            }

            if (userChoice == pairCat)
            {
                return new PairCategory();
            }
            
            if (userChoice!= pairCat || userChoice != yatzyCat || userChoice != twoPairsCat)
            {
                
                Console.WriteLine("Wrong choice. Try again.");
            }
            
            return new TwoPairsCategory();

        }

       
    }
}