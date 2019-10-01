using System;
using System.Collections.Generic;
using NUnit.Framework;
using yatzy;

namespace YatzyTest
{
    public class PairCategoryTest
    {
        [Test]
        public void CanPassNullAndThrowsException()
        {
            //arrange
            ICategory pair = new PairCategory();

            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => pair.CalculateScore(null));
        }

        [Test]
        public void Returns0WhenTehreAreNoPairs()
        {
            //arrange
            ICategory pair = new PairCategory();
            List<int> diceNumbers = new List<int>() {1, 2, 3, 4, 5};

            //act
            var score = pair.CalculateScore(diceNumbers);
            //Assert

            Assert.AreEqual(0, score);
        }

        [Test]
        public void WhenThereIsOnePairItReturnsItsSum()
        {
            //arrange
            ICategory pair = new PairCategory();
            List<int> diceNumbers = new List<int>() {1, 1, 3, 4, 5};

            //act
            var score = pair.CalculateScore(diceNumbers);
            //assert
            Assert.AreEqual(2, score);
        }

        [Test]
        public void WhenThereAReTwoTestsReturnTheSumOfTheBiggerOne()
        {
            //arrange
            ICategory pair = new PairCategory();
            List<int> diceNumbers = new List<int>() {1, 1, 3, 3, 5};

            //act
            var score = pair.CalculateScore(diceNumbers);

            //assert
            Assert.AreEqual(6, score);
        }
    }
}