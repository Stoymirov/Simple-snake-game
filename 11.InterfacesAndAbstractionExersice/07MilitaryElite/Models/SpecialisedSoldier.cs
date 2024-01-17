using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier:Private,ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string first, string second, decimal salary,Corps corps) : base(id, first, second, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Corps: {Corps}";
        }
    }
}
