﻿using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.SortStrategies
{
    internal class SortStrategy : ISortStrategy
    {
        public List<string> SortList(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Printing sorted list...");

            return list;
        }
    }
}
