// <copyright file="ListOfTriangles.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace TriangleModel
{
    public class ListOfTriangles : List<Triangle>
    {
        public void Print(ITrianglePrinter printer)
        {
            printer.Print(this);
        }
    }
}