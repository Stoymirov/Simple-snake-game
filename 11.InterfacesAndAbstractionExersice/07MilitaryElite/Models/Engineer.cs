using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string first, string second, decimal salary, Corps corps,
            IReadOnlyCollection<IRepair> repairs) : base(id, first, second, salary, corps)
        {
            Repairs = repairs;
        }

        public IReadOnlyCollection<IRepair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var repair in Repairs)
            {
                sb.AppendLine($"  {repair.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
