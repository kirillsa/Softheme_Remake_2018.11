using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new ArrayClass(10);
            arr.ShowArray();
            Console.WriteLine("Show the 3rd member is {0}",arr[3-1].ToString());
            Console.WriteLine(arr[22].ToString());
            arr.Add(2,3,1);
            arr.ShowArray();
            Console.WriteLine("Does array contains 4 number? {0}", arr.Contains(4));
            Console.ReadLine();
        }
    }
}
