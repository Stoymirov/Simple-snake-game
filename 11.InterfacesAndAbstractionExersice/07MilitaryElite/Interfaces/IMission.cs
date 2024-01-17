using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Enums;

namespace MilitaryElite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }

        void CompleteMission();
    }
}
