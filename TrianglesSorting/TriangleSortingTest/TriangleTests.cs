// <copyright file="TriangleTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

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
        [DataRow("second", 2, 2, 4)]
        public void InitializeTest_ExpectedInvalidTriangleException(string name, int a, int b, int c)
        {
            // Act
            Triangle triangle = Triangle.Initialize(name, a, b, c);
        }

        [DataTestMethod]
        [DataRow("first", 2, 4, 5)]
        public void InitializeTest_CorrectInput_ReturnNewInstanceOfTriangle(string name, int a, int b, int c)
        {
            // Arrange
            Triangle triangle;
            
            // Act
            triangle = Triangle.Initialize(name, a, b, c);

            //Assert
            Assert.IsNotNull(triangle);
            Assert.IsInstanceOfType(triangle, typeof(Triangle));
        }

        [DataTestMethod]
        [DataRow("first", 2, 4, 5)]
        public void InitializeTest_CorrectInput_ReturnNewInstanceOfTriangleWithCorrectProperties(string name, int a, int b, int c)
        {
            // Arrange
            Triangle triangle;

            // Act
            triangle = Triangle.Initialize(name, a, b, c);

            //Assert
            Assert.AreEqual(name, triangle.Name);
            Assert.AreEqual(a, triangle.A);
            Assert.AreEqual(b, triangle.B);
            Assert.AreEqual(c, triangle.C);
        }

        [DataTestMethod]
        [DataRow("first", 3, 4, 5, 6)]
        public void GetAreaTest_CorrectInput_Returned_6(string name, int a, int b, int c, float expectedArea)
        {
            // Arrange
            Triangle triangle = Triangle.Initialize(name, a, b, c);
            float actualArea;

            // Act
            actualArea = triangle.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, actualArea);
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