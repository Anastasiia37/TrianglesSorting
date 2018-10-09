using System;

namespace TrianglesSorting
{
    internal class TrianglesSortingProgram
    {
        private Validator validator;

        public TrianglesSortingProgram(Validator validator)
        {
            this.validator = validator;
        }

        private enum _returnCode
        {
            Success,
            Error
        };

        public int Run(string[] args)
        {
            try
            {
                Triangle triangle = this.validator.Check(args);
                SetOfTriangles triangles = new SetOfTriangles();
                triangles.Add(triangle);
                Console.Write(@"Do you want to add one more triangle? (If you do, print ""y"" or ""yes""): ");
                string action = Console.ReadLine().ToLower();

                while (action == "y" || action == "yes")
                {
                    Console.WriteLine("Input data for one more triangle: ");
                    string input = Console.ReadLine().ToLower();
                    triangle = this.validator.StringParse(input);
                    triangles.Add(triangle);
                    Console.Write(@"Do you want to add one more triangle? (If you do, print ""y"" or ""yes""): ");
                    action = Console.ReadLine().ToLower();
                }

                triangles.Sort(new TrianglesComparerByAreaDESC<Triangle>());
                triangles.Print(new ConsolePrinter());
            }
            catch (InvalidArgumentException exc)
            {
                Console.WriteLine(exc.Message);
                Console.ReadKey();
                return (int)_returnCode.Error;
            }

            return (int)_returnCode.Success;
        }
    }
}
