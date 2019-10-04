using System;
using System.Collections.Generic;
using NUnit.Framework;
using yatzy;

namespace YatzyTest
{
    public class FullHouseCategoryTests
    {
        
        [Test]
        public void CanPassNullAndThrowsException()
        {
            //arrange
            ICategory fullHouse = new FullHouseCategory();

            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => fullHouse.CalculateScore(null));
        }

        [Test]
        public void Returns0WhenThereAreIsntAFullHouse()
        {
            //arrange
            ICategory fullHouse = new FullHouseCategory();
            List<int> diceNumbers = new List<int>() {2, 2, 2, 2, 4};

            //act
            //assert
            Assert.AreEqual(0, fullHouse.CalculateScore(diceNumbers));
            
        }
        
        [Test]
        public void ReturnsSumWhereThereIsAFullHouse()
        {
            //arrange
            ICategory fullHouse = new FullHouseCategory();
            List<int> diceNumbers = new List<int>() {2, 2, 2, 1, 1};

            //act
            //assert
            Assert.AreEqual(8, fullHouse.CalculateScore(diceNumbers));
            
        }

        
    }
}