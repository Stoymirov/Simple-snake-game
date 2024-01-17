using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.IO.Interfaces;

namespace MilitaryElite.IO.Models
{
    public class ConsoleReaderL:IReader
    {
        public string ReadLine()
        {
           return Console.ReadLine();
        }
    }
}
