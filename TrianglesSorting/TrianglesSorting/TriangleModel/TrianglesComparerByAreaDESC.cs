using System;

namespace TriangleModel
{
    public class TrianglesComparerByAreaDESC : ITrianglesComparer 
    {
        public int Compare(Triangle triangle1, Triangle triangle2)
        {
            if (triangle2.Area - triangle1.Area < 0)
            {
                return -1;
            }

            return 1;
        }
    }
}
