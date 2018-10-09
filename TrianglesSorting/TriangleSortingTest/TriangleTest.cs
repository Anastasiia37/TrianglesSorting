using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrianglesSorting;

namespace TriangleSortingTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            //Arrange
            Triangle triangle = new Triangle("first", 2, 3, 4, new HeronsFormula());
            string expected = "[Triangle first]: 2.9 сm";

            //Act
            string actual = triangle.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validator_StringParseTest()
        {
            //Arrange
            Validator validator = new Validator();
            Triangle expected = new Triangle("qwe", 2.3f, 5, 6, new HeronsFormula());

            //Act
            Triangle actual = validator.StringParse("qwe,2.3,5,6");

            //Assert
            Assert.AreEqual(expected.A, actual.A);
            Assert.AreEqual(expected.B, actual.B);
            Assert.AreEqual(expected.C, actual.C);
        }

        //Стороны 3,5,8 - не должно работать!!
        //Сортировка для площадей 1.5 и 1.7??
        //При возвращении объектов - возвращается не нулл
        [TestMethod]
        public void SetOfTriangles_AddTest()
        {
            SetOfTriangles triangles = new SetOfTriangles();
           // triangles.Add(new Triangle("qwe", 2, 5, 6, new HeronsFormula()));
            triangles.Add(new Triangle("qwerty", 2, 3, 4, new HeronsFormula()));
           triangles.Add(new Triangle("dfghdgh", 2.3f, 3.4f, 4.5f, new HeronsFormula()));

            triangles.Sort(new TrianglesComparerByAreaDESC<Triangle>());
            triangles.Print(new ConsolePrinter());
           /* Assert.AreEqual(expected.A, actual.A);
            Assert.AreEqual(expected.B, actual.B);
            Assert.AreEqual(expected.C, actual.C);*/
        }
    }
}
