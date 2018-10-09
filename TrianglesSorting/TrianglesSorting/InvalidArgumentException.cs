using System;

namespace TrianglesSorting
{
    public class InvalidArgumentException : Exception
    {
        public InvalidArgumentException() : base()
        {
        }

        public InvalidArgumentException(string message) : base(message)
        {
        }
    }
}
