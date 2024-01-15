using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public interface IElectricCar : ICar

    {
    public int Battery { get; }
    }
}
