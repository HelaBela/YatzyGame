using System;
using System.Collections.Generic;
using NUnit.Framework;
using yatzy;

namespace YatzyTest
{
    public class ThreeOfAKindCategoryTests
    {
        [Test]
        public void CanPassNullAndThrowsException()
        {
            //arrange
            ICategory three = new ThreeOfAKindCategory();

            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => three.CalculateScore(null));
        }

        [Test]
        public void Returns0WhenThereAreNoThreeOfAKind()
        {
            //arrange
            ICategory three = new ThreeOfAKindCategory();
            List<int> diceNumbers = new List<int>() {1, 2, 3, 4, 5};

            //act
            //assert
            Assert.AreEqual(0, three.CalculateScore(diceNumbers));
            
        }

        
    }
}