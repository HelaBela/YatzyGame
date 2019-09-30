using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using yatzy;

namespace YatzyTest
{
    public class YatzyCategoryTests
    {
        [Test]
        public void TakesInNullShouldThrowException()
        {
            ICategory yatzy = new YatzyCategory();

            Assert.Throws<Exception>(() => yatzy.CalculateScore(null));
        }

        [Test]
        public void CanReturn50WhenNumbersAreTheSame()
        {
            //arrange
            ICategory yatzy = new YatzyCategory();
            List<int> finalDiceNum = new List<int>() {1, 1, 1, 1, 1};

            //act

            int actual = yatzy.CalculateScore(finalDiceNum);

            //assert
            Assert.AreEqual(50, actual);
        }

        [Test]
        public void CanReturn0WhenNumbersAreNotTheSame()
        {
            //arrange
            ICategory yatzy = new YatzyCategory();
            List<int> finalDiceNum = new List<int>() {2, 1, 1, 1, 1};

            //act

            int actual = yatzy.CalculateScore(finalDiceNum);

            //assert
            Assert.AreEqual(0, actual);
        }
    }
}