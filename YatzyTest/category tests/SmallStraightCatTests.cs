using System;
using System.Collections.Generic;
using NUnit.Framework;
using yatzy;

namespace YatzyTest
{
    public class SmallStraightCatTests
    {
        [Test]
        public void CanPassNullAndThrowsException()
        {
            //arrange
            ICategory smallStraight = new SmallStraightCategory();

            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => smallStraight.CalculateScore(null));
        }

        [Test]
        public void Returns0WhenThereIsntASmallStraight()
        {
            //arrange
            ICategory smallStraight = new SmallStraightCategory();
            List<int> diceNumbers = new List<int>() {1, 2, 3, 4, 4};

            //act
            //assert
            Assert.AreEqual(0, smallStraight.CalculateScore(diceNumbers));
            
        }
        
        [Test]
        public void Returns15WhenNumbersAreFromOneToFive()
        {
            //arrange
            ICategory smallStraight = new SmallStraightCategory();
            List<int> diceNumbers = new List<int>() {1, 2, 3, 4, 5};

            //act
            //assert
            Assert.AreEqual(15, smallStraight.CalculateScore(diceNumbers));
            
        }

        
    }
}