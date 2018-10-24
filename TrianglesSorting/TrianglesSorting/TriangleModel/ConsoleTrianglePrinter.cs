// <copyright file="ConsoleTrianglePrinter.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;

namespace TriangleModel
{
    public class ConsoleTrianglePrinter : ITrianglePrinter
    {
        public void Print(ListOfTriangles triangles)
        {
            int i = 1;
            foreach (Triangle triangle in triangles)
            {
                Console.WriteLine($"{i}. {triangle}");
                i++;
            }
        }
    }
}