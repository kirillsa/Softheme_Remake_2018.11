using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class ColorPrinter : Printer
    {
        public override void Print(string msg)
        {
            Console.WriteLine("ColorPrinter class msg: {0}", msg);
        }

        public void Print(string msg, ConsoleColor color)
        {
            var buf = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine("ColorPrinter Picture: {0}", msg);
            Console.ForegroundColor = buf;
        }
    }
}