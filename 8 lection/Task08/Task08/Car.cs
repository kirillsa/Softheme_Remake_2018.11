using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Car
    {
        public string Engine { get; private set; }
        public string Transmission { get; private set; }
        public string Color { get; private set; }

        public Car(Engine engine, Transmission transmission, Color color)
        {
            Engine = engine.EngineModel;
            Transmission = transmission.TransmissionModel;
            Color = color.ColorModel;
        }

        public void EngineChange(Engine engine)
        {
            Engine = engine.EngineModel;
        }

        public void ShowCar()
        {
            Console.WriteLine("Engine is {0} Transmission is {1} Color is {2}", Engine, Transmission, Color);
            Console.ReadLine();
        }
    }
}
