using System;
using System.Collections.Generic;

namespace yatzy
{
    public class Game
    {
        private readonly Player _player;
        private List<ICategory> categories;
        private readonly GameMessenger _messenger;

        public Game(Player player, GameMessenger messenger)
        {
            _messenger = messenger;
            this._player = player;
            categories = new List<ICategory>()
            {
                new YatzyCategory(), new PairCategory()
            };
        }

        private List<int> _rolledDiceNumbers;

        public void Start()
        {
            _rolledDiceNumbers = RollWithHeldNumbers(new List<int>());
            _messenger.DisplayDice(_rolledDiceNumbers);


            for (int i = 0; i < 2; i++)
            {
                var heldNumbers = _player.Hold(_rolledDiceNumbers);
                _rolledDiceNumbers = RollWithHeldNumbers(heldNumbers);
                _messenger.DisplayDice(_rolledDiceNumbers);
            }

            var category = _player.ChooseCategory();
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