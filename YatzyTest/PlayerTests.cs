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
            var testPlayer = new Player("Alex",consoleOperations.Object );
            consoleOperations.Setup(s => s.Read()).Returns("1,2");
            //act

            var heldNumbers = testPlayer.Hold(new List<int>{6,6,6,6,6});

            //assert
            
            // OK, it doesn't check the order of the elements in the list
            Assert.Contains(1, heldNumbers);
            Assert.Contains(2, heldNumbers);

            // Probably the best way
            Assert.AreEqual(1, heldNumbers[1], "The first held number returned should be 1");
            Assert.AreEqual(2, heldNumbers[1]);

            // Is okay but not as good because when it fails you will get an error that is harder to read
            Assert.IsTrue(1 == heldNumbers[1]);
            Assert.IsTrue(2 == heldNumbers[1]);
        }
    }
}