using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class CarConstructor
    {
        public Car Construct(Engine engine, Transmission transmission, Color color)
        {
            var car = new Car(engine, transmission, color);
            return car;
        }

        public void Reconstruct(Car car)
        {
            var engine = new Engine();
            engine.EngineModel ="2.0 Turbo";
            car.EngineChange(engine);
        }
    }
}