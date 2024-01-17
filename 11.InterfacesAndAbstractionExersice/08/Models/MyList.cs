using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    internal class MyList:IListCollection
    {
        private const int AddIndex = 0;
        private const int RemoveIndex = 0;
        public readonly List<string> list;

        public MyList()
        {
            list = new List<string>();
        }
        public int Used => list.Count;
        public int Add(string value)
        {
           list.Insert(AddIndex, value);
           return AddIndex;
        }

        public string Remove()
        {

            string item = list[RemoveIndex];
            list.Remove(item);
            return item;
        }

    }
}
