using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
public class Pet:IBornable,INamable

{
    public string Birthday { get; }
    public string Name { get; }

    public Pet(string name, string birthday)
    {
        Name = name;
        Birthday = birthday;
    }
}
}
