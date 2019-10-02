using System;
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

        
    }
}