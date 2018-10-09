using System;

namespace TrianglesSorting
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            Validator validator = new Validator();
            TrianglesSortingProgram program = new TrianglesSortingProgram(validator);
            return program.Run(args);
        }
    }
}