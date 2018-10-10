using System;
using System.Collections.Generic;

namespace TrianglesSorting
{
    public class ListOfTriangles : List<Triangle> 
    {
        //private List<Triangle> triangles_lst;
        const byte CAPACITY_INCREASING = 1;
        

        public ListOfTriangles() : base()
        {
            base.Capacity = CAPACITY_INCREASING;
        }

        public ListOfTriangles(int capacity):base(capacity)
        {
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public void Add(string name, float a, float b, float c)
        {
            if (base.Count == base.Capacity)
            {
                base.Capacity += CAPACITY_INCREASING;
            }
            base.Add(new Triangle(name, a, b, c));
        }

        public new void Add(Triangle triangle)
        {
            if (base.Count == base.Capacity)
            {
                base.Capacity += CAPACITY_INCREASING;
            }
            base.Add(triangle);
        }

        /* new public void Add(Triangle triangle)
         {
             /*if (this.Count == this.Capacity)
             {
                 this.Capacity += CAPACITY_INCREASING;
             }*/
        //this.Add(triangle);
        //}*/

        //???????
        public void Sort(ITrianglesComparer comparer)
        {
            base.Sort(comparer);
        }

        public void PrintSortedList(IPrinter printer, ITrianglesComparer comparer)
        {
            ListOfTriangles triangles = new ListOfTriangles(base.Count);
            for (int i = 0; i<base.Count; i++)
            {
                triangles.Add(base[i].Name, base[i].A, base[i].B, base[i].C);
            }
            triangles.Sort(comparer);
            printer.Print(triangles);
        }

        public void PrintList(IPrinter printer)
        {
            printer.Print(this);
        }
    }
}
