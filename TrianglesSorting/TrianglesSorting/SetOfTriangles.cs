using System;
using System.Collections.Generic;

namespace TrianglesSorting
{
    public class SetOfTriangles
    {
        private List<Triangle> triangles_lst;

        public SetOfTriangles()
        {
            this.triangles_lst = new List<Triangle>();
        }

        public void Add(Triangle triangle)
        {
            this.triangles_lst.Add(triangle);
        }

        public void Sort(ITrianglesComparer<Triangle> comparer)
        {
            this.triangles_lst.Sort(comparer);
        }

        public void Print(IPrinter printer)
        {
            printer.Print(this);
        }

        public IEnumerator<Triangle> GetEnumerator()
        {
            foreach (Triangle triangle in this.triangles_lst)
            {
                yield return triangle;
            }
        }
    }
}
