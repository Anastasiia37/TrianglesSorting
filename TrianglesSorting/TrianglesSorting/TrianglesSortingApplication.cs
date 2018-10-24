// <copyright file="TrianglesSortingApplication.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using TriangleModel;

namespace TrianglesSorting
{
    public class TrianglesSortingApplication
    {
        private ListOfTriangles triangles;

        public TrianglesSortingApplication()
        {
           this.triangles = new ListOfTriangles();
        }

        public int Run(string[] args)
        {
            try
            {
                Triangle triangle = TriangleParser.Parse(args);
                this.triangles.Add(triangle);

                string action;
                do
                {
                    Console.Write("Do you want to add one more triangle? (If you do, print \"y\" or \"yes\"): ");
                    action = Console.ReadLine().ToLower();
                    if (action == "y" || action == "yes")
                    {
                        triangle = this.GetData();
                        if (triangle != null)
                        {
                            this.triangles.Add(triangle);
                        }
                    }
                }
                while (action == "y" || action == "yes");

                Console.WriteLine("This is your list of triangles:");
                ITrianglePrinter printer = new ConsoleTrianglePrinter();
                this.triangles.Print(printer);
                Console.WriteLine("This is your sorted list:");
                this.triangles.Sort(new TrianglesComparerByAreaDesc());
                this.triangles.Print(printer);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                this.ShowInstruction();
                Console.ReadKey();
                return (int)ReturnCode.Error;
            }

            return (int)ReturnCode.Success;
        }

        private Triangle GetData()
        {
            try
            {
                Console.WriteLine("Input data for one more triangle: ");
                string input = Console.ReadLine().ToLower();
                Triangle triangle = TriangleParser.Parse(input);
                return triangle;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        private void ShowInstruction()
        {
            Console.WriteLine("Input parameters: name,length,length,length");
        }
    }
}