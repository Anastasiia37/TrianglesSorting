using System;

namespace TriangleModel
{
    public class InvalidTriangleException : Exception
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        private readonly string help = "All sides of triangle must satisfy the condition: "
                                     + "FirstSide + SecondSide > ThirdSide.";

        public InvalidTriangleException() : base()
        {
        }

        public InvalidTriangleException(string message) : base(message)
        {
        }

        public InvalidTriangleException(string message, double a, double b, double c) : this(message)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public InvalidTriangleException(string message, Exception inner) : base(message, inner)
        {
        }

        public override string ToString()
        {
            return this.Message + "\n" + this.help;
        }
    }
}
