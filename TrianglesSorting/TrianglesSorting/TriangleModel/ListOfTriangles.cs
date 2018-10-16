using System;
using System.Collections.Generic;

namespace TriangleModel
{
    public class ListOfTriangles : List<Triangle>
    {
        public void Print(ITrianglePrinter printer)
        {
            printer.Print(this);
        }
    }
}
