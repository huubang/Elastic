using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Part1;
using System.Collections.Generic;
using System.Linq;

namespace Part1.Test
{
    [TestClass]
    public class PositiveDivisorsUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InvalidNumberTest()
        {
            // Arrange
            int number = 0;            

            // Act
            var actualResult = PositiveDivisors.Of(number);
        }

        [TestMethod]
        public void TrivialNumberTest()
        {
            // Arrange
            int number = 60;
            var expectedResult = new List<int> { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 };

            // Act
            var actualResult = PositiveDivisors.Of(number);

            // Assert
            Assert.AreEqual(false, actualResult.Except(expectedResult).Any());
            Assert.AreEqual(false, expectedResult.Except(actualResult).Any());
        }
        
    }
}
