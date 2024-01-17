using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Commando:SpecialisedSoldier,ICommando
    {
        public Commando(int id, string first, string second, decimal salary, Corps corps,IReadOnlyCollection<IMission> missions) : base(id, first, second, salary, corps)
        {
            Missions = missions;
        }

        public IReadOnlyCollection<IMission> Missions { get; private set;  }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            foreach (var mission in Missions)
            {
                sb.AppendLine($"  {mission.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
