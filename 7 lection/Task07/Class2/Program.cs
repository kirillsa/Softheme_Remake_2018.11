using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hum1 = new Human("12.01.1989", "Kir","Sav");
            Console.WriteLine("Man is {0} \nFirst is {1} Age is {2}", hum1.ToString(), hum1.FirstName, hum1.Age);
            Human hum2 = new Human("12.01.1999", "Kir", "Sav");
            Console.WriteLine("Man is {0} \nFirst is {1} Age is {2}", hum2.ToString(), hum2.FirstName, hum2.Age);
            Console.WriteLine("Is Hum1 equels Hum1: {0}", hum1.Compare(hum1));
            Console.WriteLine("Is Hum1 equels Hum2: {0}", hum1.Compare(hum2));
        }
    }
}
