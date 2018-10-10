using System;

namespace TrianglesSorting
{
    public interface IPrinter
    {
        void Print(ListOfTriangles triangles);
    }

    public class ConsolePrinter : IPrinter
    {
        public void Print(ListOfTriangles  triangles)
        {
            int i = 1;
            foreach (Triangle triangle in triangles)
            {
                Console.WriteLine(triangle.ToString(i));
                i++;
            }
        }
    }
}