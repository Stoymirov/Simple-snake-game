using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarchy.Interfaces;
using Microsoft.VisualBasic.CompilerServices;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection:IPersonalAddRemoveCollection
    {
        private const int AddIndex = 0;

        public readonly List<string> list;
        public AddRemoveCollection()
        {
            list = new List<string>();
        }
        public int Add(string value)
        {
            list.Insert(AddIndex, value);
            return AddIndex;
        }

        public string Remove()
        {
            string item = null;
            if (list.Count > 0)
            {
                item = list[^1];

                list.RemoveAt(list.Count - 1);
            }
            return item;
        }
    }
}
