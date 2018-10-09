using System;

namespace TrianglesSorting
{
    public interface IPrinter
    {
        void Print(SetOfTriangles triangles);
    }

    public class ConsolePrinter : IPrinter
    {
        public void Print(SetOfTriangles triangles)
        {
            int i = 0;
            foreach (Triangle triangle in triangles)
            {
                Console.WriteLine(++i + ". " + triangle);
            }
        }
    }
}