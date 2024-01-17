using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral:Private,ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string first, string second, decimal salary,IReadOnlyCollection<IPrivate> privates) : base(id, first, second, salary)
        {
            Privates = privates;
        }

        public IReadOnlyCollection<IPrivate> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var @private in Privates)
            {
                sb.AppendLine($"  {@private.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
