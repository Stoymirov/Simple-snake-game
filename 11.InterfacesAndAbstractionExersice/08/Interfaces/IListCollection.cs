﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Interfaces
{
    public interface IListCollection:IPersonalAddRemoveCollection
    {
        public int Used { get; }
    }
}
