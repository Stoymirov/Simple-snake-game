﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Mission:IMission
    {
        public Mission(string codeName,State state)
        {
            State = state;
            CodeName = codeName;
        }
        public string CodeName { get; private set; }
        public State State { get; private set; }
        public void CompleteMission()
        {
            State = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
