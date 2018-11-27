using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CarConstructor();
            var car = factory.Construct(Engine.Two,Transmission.Auto, Color.Red);
            car.ShowCar();
            car = factory.Reconstruct(car);
            car.ShowCar();
        }
    }
}
