using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.SortStrategies
{
    internal class SortReverseStrategy : ISortStrategy
    {
        public List<string> SortList(List<string> list)
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine("Printing sorted list in reverse...");
            return list;
        }
    }
}
