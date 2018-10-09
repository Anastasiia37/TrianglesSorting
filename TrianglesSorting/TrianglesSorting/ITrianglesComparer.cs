using System;
using System.Collections.Generic;

namespace TrianglesSorting
{
    public interface ITrianglesComparer<T> : IComparer<T> where T : Triangle
    {
        new int Compare(T triangle1, T triangle2);
    }
}
