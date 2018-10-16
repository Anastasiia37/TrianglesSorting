using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleModel;

namespace TriangleSortingTests
{
    [TestClass]
    public class TriangleTests
    {
        [DataTestMethod]
        [ExpectedException(typeof(InvalidTriangleException), "Exception \"InvalidTriangleException\" wasn`t thrown")]
        [DataRow("first", 2, 2, -3)]
        [DataRow("first", 2, 2, 4)]
        public void Triangle_InitializeTest_ExpectedException(string name, int a, int b, int c)
        {
            // Act
            Triangle triangle = Triangle.Initialize(name, a, b, c);
            Triangle triangle2 = Triangle.Initialize(name, a, b, c);
        }
        
        [TestMethod]
        public void Triangle_ToStringTest()
        {
            // Arrange
            Triangle triangle = Triangle.Initialize("first", 2, 3, 4);
            string expected = "[Triangle first]: 2,9 сm";

            // Act
            string actual = triangle.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }        
    }
}
