using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public struct Car
    {
        public Engine Engine { get; private set; }
        public Transmission Transmission { get; private set; }
        public Color Color { get; private set; }

        public Car(Engine engine, Transmission transmission, Color color)
        {
            Engine = engine;
            Transmission = transmission;
            Color = color;
        }

        public void EngineChange(Engine engine)
        {
            Engine = engine;
        }

        public void ShowCar()
        {
            Console.WriteLine("Engine is {0} Transmission is {1} Color is {2}", Engine, Transmission, Color);
            Console.ReadLine();
        }
    }
}
