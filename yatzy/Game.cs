using System;
using System.Collections.Generic;
using System.Linq;
using Utility;


namespace yatzy
{
    public class Game
    {
        private readonly IConsoleService _iConsoleService;
        private readonly Player _player;
        private readonly Dictionary<String, List<ICategory>> _usedCategories;
        private readonly CategoryProvider _categoryProvider;
        private int _totalScore;


        public Game(Player player, IConsoleService iConsoleService)
        {
            _player = player;
            _iConsoleService = iConsoleService;
            _usedCategories = new Dictionary<String, List<ICategory>>();
            _usedCategories.Add(_player.Name, new List<ICategory>());
            _categoryProvider = new CategoryProvider();
            _totalScore = 0;
        }


        public void Start()
        {
            var availableCategories = _categoryProvider.GetCategories(_usedCategories[_player.Name]);

            while (availableCategories.Any())
            {
                var rolledNumbers = RollDice();

                var category = _player.ChooseCategory(availableCategories, rolledNumbers);

                _usedCategories[_player.Name].Add(category);

                var score = GetCategoryScore(category, rolledNumbers);


                foreach (var usedCat in _usedCategories)
                {
                    _totalScore += score;
                }


                _iConsoleService.Write($"Here is your score for this round: {score}, your total score is: {_totalScore}");

                availableCategories = _categoryProvider.GetCategories(_usedCategories[_player.Name]);
            }
        }



        private List<int> RollDice()
        {
            var rolledNumbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                rolledNumbers.Add(new Random().Next(1, 7));
            }

            var heldNumbers = new List<int>();


            for (int i = 0; i < 2; i++)
            {
                heldNumbers.AddRange(_player.Hold(rolledNumbers));
                rolledNumbers = RollWithHeldNumbers(heldNumbers, rolledNumbers);
            }

            return rolledNumbers;
        }

        private int GetCategoryScore(ICategory category, List<int> rolledNumbers)
        {
            var score = category.CalculateScore(rolledNumbers);

            return score;
        }


        private List<int> RollWithHeldNumbers(List<int> positionsToHold, List<int> rolledNumbers)
        {
            var newRolledNumbers = rolledNumbers.ToList();
            for (int i = 0; i < rolledNumbers.Count; i++)
            {
                if (!positionsToHold.Contains(i))
                {
                    newRolledNumbers[i] = new Random().Next(1, 7);
                }
            }

            return newRolledNumbers;
        }
    }
}