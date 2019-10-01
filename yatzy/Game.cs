using System;
using System.Collections.Generic;

namespace yatzy
{
    public class Game
    {
        private readonly Player _player;
        public Dictionary<String, List<ICategory>> UsedCategories; 


        public Game(Player player)
        {
            this._player = player;
            UsedCategories = new Dictionary<String, List<ICategory>>();
            UsedCategories.Add(_player.Name, new List<ICategory>());
        }

        private static List<int>
            _rolledDiceNumbers; //tomorrow, or later on... this should go to player, coz its a responsibility of player ot rememeber the rolled dice result

        public void Start()
        {
            _rolledDiceNumbers = RollWithHeldNumbers(new List<int>());


            RollDice();

            CategoryProvider categoryProvider = new CategoryProvider();
            var availableCategories = categoryProvider.GetCategories(UsedCategories[_player.Name]);

            var category =
                _player.ChooseCategory(availableCategories,
                    _rolledDiceNumbers); // check if this category was not used. Dont trust the player - do I still need to do that, how?

            UsedCategories[_player.Name].Add(category);

            var score = GetCategoryScore(category);
            Console.WriteLine($"Here is your score: {score}");
            //_player.UpdateScore(TotalScore(category));

            RollDiceSecondRound();

        }

        private void RollDiceSecondRound()
        {

            for (int i = 0; i < 2; i++)
            {
                var heldNumbers = _player.Hold(_rolledDiceNumbers);
                _rolledDiceNumbers = RollWithHeldNumbers(heldNumbers);
            }
        }

        private void RollDice()
        {
            for (int i = 0; i < 2; i++)
            {
                var heldNumbers = _player.Hold(_rolledDiceNumbers);
                _rolledDiceNumbers = RollWithHeldNumbers(heldNumbers);
            }
        }


       // private int
//            TotalScore(ICategory category) // the score should be tided to player. Game will update the score.player.getScore
//        {
//            var totalScore = 0;
//
//            foreach (var usedCategory in UsedCategories[_player])
//            {
//                totalScore += GetCategoryScore(usedCategory.CalculateScore(finalDiceNumbers:));
//            }
//
//            return totalScore; //player.updateScore and tell player this is your score:
//        }

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