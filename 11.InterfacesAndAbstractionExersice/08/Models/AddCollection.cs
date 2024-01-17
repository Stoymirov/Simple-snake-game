using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    internal class AddCollection:IPersonalAddCollection
    {
        public readonly List<string> list;
        public AddCollection()
        {
            list = new List<string>();
        }

        public int Add(string value)
        {
            list.Add(value);
            return list.IndexOf(value);
        }
    }
}
