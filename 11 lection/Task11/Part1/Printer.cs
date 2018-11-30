using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Printer
    {
        public virtual void Print(string msg)
        {
            Console.WriteLine("Base class msg: {0}", msg);
        }
    }
}