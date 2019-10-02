using Moq;
using NUnit.Framework;
using Utility;
using yatzy;

namespace YatzyTest
{
    public class GameTests
    {
        [Test]
        public void HoldsNubersOnTheSamePosition()
        {
            //arrange
            var consoleOperationsMock = new Mock<IConsoleService>();
            Player testPlayer = new Player("Alex", consoleOperationsMock.Object);
            Game testGame = new Game(testPlayer, consoleOperationsMock.Object);
            
            //act
            
            
            
            //assert
            Assert.Pass();
        }

        [Test]
        public void RollsDice()
        {
            //arrange

            IConsoleService testServices = new ConsoleOperations();
            Player testPlayer = new Player("Alex", testServices);
            Game testGame = new Game(testPlayer, testServices);
            
            //act
            testGame.Start();

            //Assert
            //Assert.Contains();
            // Assert.AreEqual();

        }

    }
}