// <copyright file="TrianglesComparerByAreaDesc.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace TriangleModel
{
    public class TrianglesComparerByAreaDesc : ITrianglesComparer 
    {
        public int Compare(Triangle triangle1, Triangle triangle2)
        {
            if (triangle2.GetArea() - triangle1.GetArea() < 0)
            {
                return -1;
            }

            return 1;
        }
    }
}