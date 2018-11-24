using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeDescriptor fig1 = new ShapeDescriptor(1, 2);
            ShapeDescriptor fig2 = new ShapeDescriptor(1, 2, 3, 4);
            ShapeDescriptor fig3 = new ShapeDescriptor(1, 2, 3, 4, 5, 6);
            Console.WriteLine("Fig1 is {0} Fig2 is {1} Fig3 is {2}", fig1.ShapeType, fig2.ShapeType, fig3.ShapeType);
        }
    }
}
