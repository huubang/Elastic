using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Part1;
using System.Collections.Generic;
using System.Linq;

namespace Part1.Test
{
    [TestClass]
    public class ExtensionsUnitTest
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            // Arrange
            string empty = string.Empty;

            // Act
            bool isNullOrEmpty = empty.IsNullOrEmpty();

            // Assert
            Assert.AreEqual(true, isNullOrEmpty);
        }

        [TestMethod]
        public void NullStringTest()
        {
            // Arrange
            string nullString = null;

            // Act
            bool isNullOrEmpty = nullString.IsNullOrEmpty();

            // Assert
            Assert.AreEqual(true, isNullOrEmpty);
        }

        [TestMethod]
        public void NonEmptyStringTest()
        {
            // Arrange
            string normalString = "Just a test";

            // Act
            bool isNullOrEmpty = normalString.IsNullOrEmpty();

            // Assert
            Assert.AreEqual(false, isNullOrEmpty);
        }

        [TestMethod]
        public void MostAppearanceDuplicateTest()
        {
            // Arrange
            var sequence = new List<int> { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 };
            var expectedResult = new List<int> { 5, 4 };

            // Act
            var actualResult = sequence.MostAppearance();

            // Assert
            Assert.AreEqual(false, actualResult.Except(expectedResult).Any());
            Assert.AreEqual(false, expectedResult.Except(actualResult).Any());
        }

        [TestMethod]
        public void MostAppearanceDistinctTest()
        {
            // Arrange
            var sequence = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            var actualResult = sequence.MostAppearance();

            // Assert
            Assert.AreEqual(false, actualResult.Except(expectedResult).Any());
            Assert.AreEqual(false, expectedResult.Except(actualResult).Any());
        }
    }
}
