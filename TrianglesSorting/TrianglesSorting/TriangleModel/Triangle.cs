using System;

namespace TriangleModel
{
    public class Triangle : IGeometry
    {
        private Triangle(string name, float a, float b, float c)
        {
            this.Name = name;
            this.A = a;
            this.B = b;
            this.C = c;
            this.Area = this.GetArea();
        }

        public string Name
        {
            get;
            private set;
        }

        public float A
        {
            get;
            private set;
        }

        public float B
        {
            get;
            private set;
        }

        public float C
        {
            get;
            private set;
        }

        public float Area
        {
            get;
            private set;
        }

        public static Triangle Initialize(string name, float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new InvalidTriangleException("Triangle can not have negative values of sides! "
                    + "Please, check your input parameters!", a, b, c);
            }

            if ((a + b) <= c || (b + c) <= a || (a + c) <= b)
            {
                throw new InvalidTriangleException("Can`t build triangle with such values of sides! "
                    + "Please, check your input parameters!", a, b, c);
            }

            return new Triangle(name, a, b, c);
        }

        public float GetArea()
        {
            float p = (this.A + this.B + this.C) / 2;
            return (float)Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }

        public override string ToString()
        {
            return "[Triangle " + this.Name + "]: " + string.Format("{0:0.##}", this.Area) + " сm";
        }
    }
}
