using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrianglesSorting;

namespace TriangleSortingTest
{
    [TestClass]
    public class SetOfTrianglesTest
    {
        [TestMethod]
        public void SortTest()
        {
            List<Triangle> input_lst = new List<Triangle>();
            input_lst.Add(new Triangle("1", 4, 5, 6, new HeronsFormula()));
            input_lst.Add(new Triangle("2", 2, 3, 4, new HeronsFormula()));
            input_lst.Add(new Triangle("3", 1, 2, 3, new HeronsFormula()));
            input_lst.Add(new Triangle("4", 6, 7, 8, new HeronsFormula()));
            input_lst.Add(new Triangle("5", 5, 6, 7, new HeronsFormula()));

            List<Triangle> expected_lst = new List<Triangle>();
            expected_lst.Add(new Triangle("4", 6, 7, 8, new HeronsFormula()));
            expected_lst.Add(new Triangle("5", 5, 6, 7, new HeronsFormula()));
            expected_lst.Add(new Triangle("1", 4, 5, 6, new HeronsFormula()));
            expected_lst.Add(new Triangle("2", 2, 3, 4, new HeronsFormula()));
            expected_lst.Add(new Triangle("3", 1, 2, 3, new HeronsFormula()));

            TrianglesComparerByAreaDESC<Triangle> comparer 
                = new TrianglesComparerByAreaDESC<Triangle>();

            input_lst.Sort(comparer);
            Console.WriteLine(input_lst[0]); 
             Console.WriteLine(expected_lst[0]);

            CollectionAssert.AreEquivalent(expected_lst, input_lst);
        }
    }
}
