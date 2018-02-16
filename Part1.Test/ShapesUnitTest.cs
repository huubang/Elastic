using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Part1;
using System.Collections.Generic;
using System.Linq;

namespace Part1.Test
{
    [TestClass]
    public class ShapesUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void InvalidTrianglePositiveEdgesTest()
        {            
            var area = Triangle.ComputeArea(5, 8, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void InvalidTriangleNegativeEdgesTest()
        {
            var area = Triangle.ComputeArea(-5, 8, 3);
        }

        [TestMethod]
        public void TrivialTriangleAreaTest()
        {
            // Arrange
            var triangle = new Triangle(7, 5, 10);

            // Act
            double area = triangle.ComputeArea();

            // Assert
            Assert.AreEqual(16.25, area);
        }

        [TestMethod]
        public void TrivialTrianglePerimeterTest()
        {
            // Arrange
            var triangle = new Triangle(7, 5, 10);

            // Act
            double p = triangle.ComputePerimeter();

            // Assert
            Assert.AreEqual(22, p);
        }
        
    }
}
