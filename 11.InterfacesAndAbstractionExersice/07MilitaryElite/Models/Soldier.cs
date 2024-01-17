using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Soldier:ISoldier
    {

        public Soldier(int id, string first, string second)
        {
            Id = id;
            FirstName= first;
            LastName= second;
        }
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public override string ToString() => $"Name: {FirstName} {LastName} Id: {Id}";

    }
}
