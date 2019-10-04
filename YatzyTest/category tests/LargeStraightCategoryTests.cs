using System;
using System.Collections.Generic;
using NUnit.Framework;
using yatzy;

namespace YatzyTest
{
    public class LargeStraightCategoryTests
    {
        
        [Test]
        public void CanPassNullAndThrowsException()
        {
            //arrange
            ICategory largeStraight = new LargeStraightCategory();

            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => largeStraight.CalculateScore(null));
        }

        [Test]
        public void Returns0WhenThereAreIsntALageStraight()
        {
            //arrange
            ICategory largeStraight = new LargeStraightCategory();
            List<int> diceNumbers = new List<int>() {1, 2, 3, 4, 4};

            //act
            //assert
            Assert.AreEqual(0, largeStraight.CalculateScore(diceNumbers));
            
        }
        
        [Test]
        public void ReturnsSumWhereThereIsALargeStraight()
        {
            //arrange
            ICategory largeStraight = new LargeStraightCategory();
            List<int> diceNumbers = new List<int>() {2, 3, 4, 5, 6};

            //act
            //assert
            Assert.AreEqual(20, largeStraight.CalculateScore(diceNumbers));
            
        }

        
    }
}