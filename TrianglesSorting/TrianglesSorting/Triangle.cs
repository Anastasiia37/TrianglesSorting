using System;

namespace TrianglesSorting
{
    public class Triangle : IGeometry
    {
        public Triangle(string name, float a, float b, float c)
        {
            this.Name = name;
            this.A = a;
            this.B = b;
            this.C = c;
            this.Area = GetArea();
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

        public float GetArea()
        {
            float p = (this.A + this.B + this.C) / 2;
            return (float)Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }

        public string ToString(int index)
        {
            double roundArea = Math.Round(this.Area, 2);
            return index + ". " + "[Triangle " + this.Name + "]: "
                + string.Format("{0:F2}", roundArea) + " сm";
        }
        
        public override string ToString()
        {
            return "[Triangle " + this.Name + "]: "
                + this.A + ", " + this.B + ", " + this.C;
        }
    }
}
