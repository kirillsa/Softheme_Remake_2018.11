using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
                {
                    Color = ConsoleColor.Black,
                    Model = "BMW",
                    Year = 2018
                };
            Console.WriteLine("Car model is {0}, color is {1}", car.Model, car.Color);
            TuningAtelier.TuneCar(car);
            Console.WriteLine("Car model is {0}, color is {1}", car.Model, car.Color);
        }
    }
}
