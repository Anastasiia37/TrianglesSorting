using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleModel;

namespace TriangleSortingTests
{
    [TestClass]
    public class TrianglesComparerByAreaDESCTest
    {
        [TestMethod]
        public void TrianglesComparerByAreaDESC_Test()
        {
            // Arrange
            Triangle triangle1 = Triangle.Initialize("1", 4, 5, 6);
            Triangle triangle2 = Triangle.Initialize("2", 2, 3, 4);
            Triangle triangle3 = Triangle.Initialize("3", 1, 2.5f, 3);
            Triangle triangle4 = Triangle.Initialize("4", 2.3f, 3.4f, 4.5f);
            Triangle triangle5 = Triangle.Initialize("5", 5, 6, 7);

            ListOfTriangles input = new ListOfTriangles();
            input.Add(triangle1);
            input.Add(triangle2);
            input.Add(triangle3);
            input.Add(triangle4);
            input.Add(triangle5);
            ListOfTriangles expected = new ListOfTriangles();
            expected.Add(triangle5);
            expected.Add(triangle1);
            expected.Add(triangle4);
            expected.Add(triangle2);
            expected.Add(triangle3);

            TrianglesComparerByAreaDESC comparer 
                = new TrianglesComparerByAreaDESC();

            // Act
            input.Sort(comparer);

            // Assert
            CollectionAssert.AreEqual(input, expected);
        }
    }
}
