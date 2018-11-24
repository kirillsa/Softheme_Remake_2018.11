using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class ShapeDescriptor
    {
        private readonly Point A;
        private readonly Point B;
        private readonly Point C;
        public string ShapeType { get; private set; }

        public ShapeDescriptor(int x, int y)
        {
            A = new Point(x, y);
            ShapeType = "point";
        }

        public ShapeDescriptor(int x, int y, int x1, int y1):
            this(x, y)
        {
            B = new Point(x1, y1);
            ShapeType = "line";
        }

        public ShapeDescriptor(int x, int y, int x1, int y1, int x2, int y2) :
            this(x, y, x1, y1)
        {
            C = new Point(x2, y2);
            ShapeType = "triangle";
        }
    }
}
