using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{
    public class Citizen:IPerson,IResident
    {
        public string Name { get; set; }
        public string countrey { get; set; }
        public int Age { get; set; }
       
      


         string IResident.GetName() => $"Mr/Ms/Mrs {(Name)}";
         string IPerson.GetName() => Name;
       

    }
}
