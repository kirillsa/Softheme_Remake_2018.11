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
            var engine = new Engine() { EngineModel = "2.0" };
            var transmission = new Transmission() { TransmissionModel = "Mechanics" };
            var color = new Color() { ColorModel = "Black" };
            var factory = new CarConstructor();
            var car = factory.Construct(engine,transmission,color);
            car.ShowCar();
            factory.Reconstruct(car);
            car.ShowCar();
        }
    }
}
