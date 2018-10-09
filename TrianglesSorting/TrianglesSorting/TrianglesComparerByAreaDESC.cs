using System;

namespace TrianglesSorting
{
    public class TrianglesComparerByAreaDESC<T> : ITrianglesComparer<T> where T : Triangle
    {
        public int Compare(T triangle1, T triangle2)
        {
            if (triangle2.Area - triangle1.Area < 0)
            {
                return -1;
            }

            return 1;
        }
    }
}
