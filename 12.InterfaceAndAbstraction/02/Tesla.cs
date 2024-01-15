using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Tesla:IElectricCar
    {
        public string Model { get; }
        public string Color { get; }
        public int Battery { get; }

        public Tesla(string model,string color, int battery)
        {
            Battery = battery;
            Model = model;
            Color = color;
        }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Tesla Model {Model} with {Battery} Batteries.";
            ;
        }
    }
}
