using System;

namespace TrianglesSorting
{
    public class InvalidArgumentException : Exception
    {
        protected readonly string instruction = "Input parameters: name,length,length,length";
        public InvalidArgumentException() : base()
        {
        }

        public InvalidArgumentException(string message) : base(message)
        {
        }

        public InvalidArgumentException(string message, Exception inner) : base(message, inner)
        {
        }

        public override string ToString()
        {
            return this.Message + "\n" + instruction;
        }
    }

    public class ArgumentParseException : InvalidArgumentException
    {
        public ArgumentParseException() : base()
        {
        }

        public ArgumentParseException(string message) : base(message)
        {
        }

        public ArgumentParseException(string message, Exception inner) : base(message, inner)
        {
        }
    }

    public class IncorrectNumberOFArgumentsException : InvalidArgumentException
    {
        public IncorrectNumberOFArgumentsException() : base()
        {
        }

        public IncorrectNumberOFArgumentsException(string message) : base(message)
        {
        }

        public IncorrectNumberOFArgumentsException(string message, Exception inner) : base(message, inner)
        {
        }

        public override string ToString()
        {
            return this.Message + "\n" + instruction;
        }
    }

    public class WrongTriangleException : InvalidArgumentException
    {
        readonly Triangle triangle;
        public WrongTriangleException() : base()
        {
        }

        public WrongTriangleException(string message) : base(message)
        {
        }

        public WrongTriangleException(string message, Triangle triangle) : this(message)
        {
            this.triangle = triangle;
        }

        public WrongTriangleException(string message, Exception inner) : base(message, inner)
        {
        }

        public override string ToString()
        {
            return triangle.ToString() + "\n" + this.Message + "\n" +  instruction;
        }
    }


}
