using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace BirthdayCelebrations
{
    public class Citizen:ISomethingable,INamable,IBornable
    {
        public Citizen(string id, string name,int age,string birthday)
        {
            Name = name;
            Id = id;
            Age = age;
            Birthday = birthday;
        }
        public string Id { get; }
        public string Name { get; }
        public int Age{get; }
        public string Birthday { get; }
    }
}
