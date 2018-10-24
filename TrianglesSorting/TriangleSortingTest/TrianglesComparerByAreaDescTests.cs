// <copyright file="TrianglesComparerByAreaDESCTest.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleModel;

namespace TriangleSortingTests
{
    [TestClass]
    public class TrianglesComparerByAreaDescTests
    {
        [TestMethod]
        public void CompareTest_CorrectInput()
        {
            // Arrange
            Triangle triangle1 = Triangle.Initialize("1", 4, 5, 6);
            Triangle triangle2 = Triangle.Initialize("2", 2, 3, 4);
            TrianglesComparerByAreaDesc comparer = new TrianglesComparerByAreaDesc();
            int expected = triangle2.GetArea().CompareTo(triangle1.GetArea());
            int actual;

            // Act
            actual = comparer.Compare(triangle1, triangle2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SotrTest_CorrectInput()
        {
            // Arrange
            Triangle triangle1 = Triangle.Initialize("1", 4, 5, 6);
            Triangle triangle2 = Triangle.Initialize("2", 2, 3, 4);
            Triangle triangle3 = Triangle.Initialize("3", 1, 2.5f, 3);
            Triangle triangle4 = Triangle.Initialize("4", 2.3f, 3.4f, 4.5f);
            Triangle triangle5 = Triangle.Initialize("5", 5, 6, 7);

            ListOfTriangles actual = new ListOfTriangles();
            actual.Add(triangle1);
            actual.Add(triangle2);
            actual.Add(triangle3);
            actual.Add(triangle4);
            actual.Add(triangle5);
            ListOfTriangles expected = new ListOfTriangles();
            expected.Add(triangle5);
            expected.Add(triangle1);
            expected.Add(triangle4);
            expected.Add(triangle2);
            expected.Add(triangle3);

            TrianglesComparerByAreaDesc comparer = new TrianglesComparerByAreaDesc();

            // Act
            actual.Sort(comparer);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}