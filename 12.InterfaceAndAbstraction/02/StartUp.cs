using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Yellow");
            IElectricCar tesla = new Tesla("3", "Red", 2);
            Console.WriteLine(seat);
            Console.WriteLine(tesla);
        }
    }
}
