using System;

namespace TrianglesSorting
{
    public class TrianglesSortingProgram
    {
        private static ListOfTriangles triangles;
        int a;


        public TrianglesSortingProgram()
        {
            triangles = new ListOfTriangles();
        }

        private enum _returnCode
        {
            Success,
            Error
        };

        int b;


        public int Run(string[] args)
        {
            try
            {
                Triangle triangle = TriangleValidator.Parse(args);
                TrianglesSortingProgram.triangles.Add(triangle);
                Console.Write("Do you want to add one more triangle? (If you do, print \"y\" or \"yes\"): ");
                string action = Console.ReadLine().ToLower();

                while (action == "y" || action == "yes")
                {
                    triangle = GetData();
                    if (triangle != null)
                    {
                        triangles.Add(triangle);
                    }
                    Console.Write("Do you want to add one more triangle? (If you do, print \"y\" or \"yes\"): ");
                    action = Console.ReadLine().ToLower();
                }

                Console.WriteLine("This is your list:");
                triangles.PrintList(new ConsolePrinter());
                Console.WriteLine("This is your sorted list:");
                triangles.PrintSortedList(new ConsolePrinter(), new TrianglesComparerByAreaDESC());

            }
            catch (InvalidArgumentException exc)
            {
                Console.WriteLine(exc);
                Console.ReadKey();
                return (int)_returnCode.Error;
            }

            return (int)_returnCode.Success;
        }

        Triangle GetData()
        {
            try
            {
                Console.WriteLine("Input data for one more triangle: ");
                string input = Console.ReadLine().ToLower();
                Triangle triangle = TriangleValidator.Parse(input);
                return triangle;
            }
            catch (ArgumentParseException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
