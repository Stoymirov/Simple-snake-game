using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string first, string second, decimal salary) : base(id, first, second)
        {
            Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {

            return base.ToString() + $" Salary: {Salary:f2}";
        }

    }
}
