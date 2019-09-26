using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            name = Name;
        }

        //public List<int> Hold(List<int> rolledNumbers)
        // {
        // Console.Writeline($"Roll:  {rolledNumbers}")
        // Console.Writeline("Please enter positions you want to hold")
        // var heldNumbers = Console.ReadLine()
        // change to list and return

        //}

        public List<int> Hold(List<int> rollResults)
        {

            Console.WriteLine("choose index number 0-5 of numbers you want to hold separated with a coma");

            var numbersToHold = new List<int>();

            var userAnswer = Console.ReadLine();

            List<string> choosenNumbersToHold = userAnswer.Split(",").ToList();

            foreach (var number in choosenNumbersToHold)
            {
                numbersToHold.Add(int.Parse(number));
            }

            return numbersToHold;
        }


        public ICategory ChooseCategory()
        {
           
            Console.WriteLine(
                "choose which category you want to use to count your score: type '1' for Yatzy and type '2' for Two in a kind");

            var userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                return new YatzyCategory();
            }

            else return new PairCategory();
        }
    }
}