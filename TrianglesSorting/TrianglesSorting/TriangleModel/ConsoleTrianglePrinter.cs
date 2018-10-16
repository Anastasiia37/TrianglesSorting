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
