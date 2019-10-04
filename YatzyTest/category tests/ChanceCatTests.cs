using System;
using System.Collections.Generic;
using NUnit.Framework;
using yatzy;

namespace YatzyTest
{
    public class ChanceCatTests
    {
        [Test]
        public void CanPassNullAndThrowsException()
        {
            //arrange
            ICategory chance = new ChanceCategory();

            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => chance.CalculateScore(null));
        }
        
        
        [Test]
        public void Returns0WhenThereAreNoThreeOfAKind()
        {
            //arrange
            ICategory chance = new ChanceCategory();
            List<int> diceNumbers = new List<int>() {1, 2, 3, 4, 5};

            //act
            //assert
            Assert.AreEqual(15, chance.CalculateScore(diceNumbers));
            
        }
        
    }
}