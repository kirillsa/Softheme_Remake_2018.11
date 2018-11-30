using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string msg)
        {
            Console.WriteLine("PhotoPrinter class msg: {0}", msg);
        }

        public void Print(Photo msg)
        {
            Console.WriteLine("PhotoPrinter Picture: {0}", msg);
        }
    }
}
