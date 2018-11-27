using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class CarConstructor
    {
        public Car Construct(Engine engine, Transmission transmission, Color color)
        {
            var car = new Car(engine, transmission, color);
            return car;
        }

        public Car Reconstruct(Car car)
        {
            car.EngineChange(Engine.TwoTurbo);
            return car;
        }
    }
}