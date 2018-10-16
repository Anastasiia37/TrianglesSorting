using System;
using System.Collections.Generic;

namespace TriangleModel
{
    public interface ITrianglesComparer : IComparer<Triangle> 
    {
        new int Compare(Triangle triangle1, Triangle triangle2);
    }
}
