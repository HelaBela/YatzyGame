using System;
using System.Collections.Generic;

namespace yatzy
{
    public class Game
    {
        private readonly Player _player;
        private List<ICategory> categories;
        private readonly GameMessenger _messenger;
        public  List<ICategory> UsedCategories; //this has to be on game
        //can this be public? How about the static complained from the Player Class?

        public Game(Player player, GameMessenger messenger)
        {
            _messenger = messenger;
            this._player = player;
            categories = new List<ICategory>()
            {
                new YatzyCategory(), new PairCategory(), new TwoPairsCategory()
            };
            
            UsedCategories = new List<ICategory>();
        }

        private static List<int> _rolledDiceNumbers; //tomorrow... this should go to player, coz its a responsibility of player ot rememeber the rolled dice result

        public void Start()
        {
            _rolledDiceNumbers = RollWithHeldNumbers(new List<int>());
            _messenger.DisplayDice(_rolledDiceNumbers);


            RollDice();

            var category = _player.ChooseCategory(); // check if this category was not used. Dont trust the player
            
            UsedCategories.Add(category); //can be a map of player and used cat. UsedCatByPlayer.Key:playername Value: catList
            
            var score = GetCategoryScore(category);
            Console.WriteLine($"Here is your score: {score}");
            _player.UpdateScore(TotalScore(category));
        }

        private void RollDice()
        {
            for (int i = 0; i < 2; i++)
            {
                var heldNumbers = _player.Hold(_rolledDiceNumbers);
                _rolledDiceNumbers = RollWithHeldNumbers(heldNumbers);
                _messenger.DisplayDice(_rolledDiceNumbers);//this will happen on player
            }
        }


        private int TotalScore(ICategory category) // the score should be tided to player. Game will update the score.player.getScore
        {
            
            var totalScore = 0;

            foreach (var usedCategory in UsedCategories)
            {
                totalScore += GetCategoryScore(usedCategory);
            }
            
            return totalScore; //player.updateScore and tell player this is your score:
        }

        private int GetCategoryScore(ICategory category)
        {
            var score = category.CalculateScore(_rolledDiceNumbers);

            return score;
        }


        private List<int> RollWithHeldNumbers(List<int> numbersToHold)
        {
            var result = new List<int>();

            foreach (var number in numbersToHold)
            {
                result.Add(_rolledDiceNumbers[number]);
            }

            Random newNumber = new Random();

            for (int i = 0; i <= 4 - numbersToHold.Count; i++)
            {
                result.Add(newNumber.Next(1, 7));
            }

            return result;
        }
    }
}