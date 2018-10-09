using System;

namespace TrianglesSorting
{
    public class Triangle
    {
        public Triangle(string name, float a, float b, float c, IAreaSearchFormula areaSearchFormula)
        {
            this.Name = name;
            this.A = a;
            this.B = b;
            this.C = c;
            this.Area = areaSearchFormula.FindArea(this);
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

        public override string ToString()
        {
            double roundArea = Math.Round(this.Area, 2);
            return "[Triangle " + this.Name + "]: "
                + string.Format("{0:F2}", roundArea) + " сm";
        }
    }
}
