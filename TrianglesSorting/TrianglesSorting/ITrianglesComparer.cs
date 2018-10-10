using System;
using System.Collections.Generic;

namespace TrianglesSorting
{
    public interface ITrianglesComparer : IComparer<Triangle> 
    {
        new int Compare(Triangle triangle1, Triangle triangle2);
    }
}
