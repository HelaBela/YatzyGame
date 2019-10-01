using System;
using System.Collections.Generic;
using NUnit.Framework;
using yatzy;

namespace YatzyTest
{
    public class TwoPairsCategoryTests
    {
        [Test]
        public void CanTakeNullAndThrowException()
        {
            //Arrange
            ICategory twoPairs = new TwoPairsCategory();
            
            //Act
            
            //Assert
            Assert.Throws<ArgumentNullException>(() => twoPairs.CalculateScore(null));
        }

        [Test]
        public void CanReturn0WhenThereAreNotTwoPairs()
        {
            //Arrange
            ICategory twoPairs = new TwoPairsCategory();
            List<int> finalDice = new List<int>(){1,2,5,3,4};
            
            //Act
            var score = twoPairs.CalculateScore(finalDice);
            //Assert
            
            Assert.AreEqual(0, score);
        }
        
        [Test]
        public void CanReturn0WhenThereIsOnePair()
        {
            //Arrange
            ICategory twoPairs = new TwoPairsCategory();
            List<int> finalDice = new List<int>(){1,2,2,3,4};
            
            //Act
            var score = twoPairs.CalculateScore(finalDice);
            //Assert
            
            Assert.AreEqual(0, score);
        }
        
           
        [Test]
        public void CanReturnSumOfPairsWhenThereAreTwoPairs()
        {
            //Arrange
            ICategory twoPairs = new TwoPairsCategory();
            List<int> finalDice = new List<int>(){1,2,2,3,3};
            
            //Act
            var score = twoPairs.CalculateScore(finalDice);
            //Assert
            
            Assert.AreEqual(10, score);
        }
        
            
        [Test]
        public void CanReturnSumOfPairsWhenThereIsAPairAndThreeOfAKind()
        {
            //Arrange
            ICategory twoPairs = new TwoPairsCategory();
            List<int> finalDice = new List<int>(){1,1,1,3,3};
            
            //Act
            var score = twoPairs.CalculateScore(finalDice);
            //Assert
            
            Assert.AreEqual(8, score);
        }
        
              
        [Test]
        public void CanReturnSumOfPairsWhenThereAreFourOfAKind()
        {
            //Arrange
            ICategory twoPairs = new TwoPairsCategory();
            List<int> finalDice = new List<int>(){1,3,3,3,3};
            
            //Act
            var score = twoPairs.CalculateScore(finalDice);
            //Assert
            
            Assert.AreEqual(12, score);
        }

        
        
    }
}