using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Repair:IRepair
    {
        public Repair(string partName,int hoursWork)
        {
            PartName = partName;
            HoursWork = hoursWork;
        }
        public string PartName { get; private set; }
        public int HoursWork { get; private set; }

        public override string ToString() => $"Part Name: {PartName} Hours Worked: {HoursWork}";

    }
}
