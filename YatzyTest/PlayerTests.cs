using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Utility;
using yatzy;

namespace YatzyTest
{
    public class PlayerTests
    {
        [Test]
        public void GivenTheUser_HoldsIndexNumbersOneAndTwo_ThePlayerShouldReturnTheListWithIt()
        {
            //arrange
            var consoleOperations = new Mock<IConsoleService>();
            var testPlayer = new Player("Alex", consoleOperations.Object);
            consoleOperations.Setup(s => s.Read()).Returns("1,2");
            //act

            var heldNumbers = testPlayer.Hold(new List<int> {6, 6, 6, 6, 6});

            //assert

            // OK, it doesn't check the order of the elements in the list
            Assert.Contains(1, heldNumbers);
            Assert.Contains(2, heldNumbers);

            // Probably the best way
            Assert.AreEqual(1, heldNumbers[0], "The first held number returned should be 1");
            Assert.AreEqual(2, heldNumbers[1]);

            // Is okay but not as good because when it fails you will get an error that is harder to read
            Assert.IsTrue(1 == heldNumbers[0]);
            Assert.IsTrue(2 == heldNumbers[1]);
        }

        [Test]
        public void WhenUserPressesZeroWhilePromptTOChooseCategory_ThePairCategoryIsChosen()
        {
            //arrange
            var consoleOperations = new Mock<IConsoleService>();
            var testPlayer = new Player("Alex", consoleOperations.Object);
            var testGame = new Game(testPlayer, consoleOperations.Object);
            consoleOperations.Setup(s => s.Read()).Returns("0");
            var availableCategories = new List<ICategory>()
                {new PairCategory(), new YatzyCategory(), new TwoPairsCategory()};
            var rolledDice = new List<int>() {1, 1, 2, 2, 4};

            //act

            var chosenCat = testPlayer.ChooseCategory(availableCategories, rolledDice);


            //assert
            Assert.AreEqual(typeof(PairCategory), chosenCat.GetType());
        }
    }
}