// <copyright file="ITrianglesComparer.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace TriangleModel
{
    public interface ITrianglesComparer : IComparer<Triangle> 
    {
        new int Compare(Triangle triangle1, Triangle triangle2);
    }
}