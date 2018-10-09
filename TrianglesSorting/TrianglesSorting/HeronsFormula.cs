using System;

namespace TrianglesSorting
{
    public class HeronsFormula : IAreaSearchFormula
    {
        public float FindArea(Triangle triangle)
        {
            float p = (triangle.A + triangle.B + triangle.C) / 2;
            return (float)Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
        }
    }
}
