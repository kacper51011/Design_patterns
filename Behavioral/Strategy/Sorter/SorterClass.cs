using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sorter
{
    public class SorterClass
    {
        // Holds actual chosen sort strategy
        private ISortStrategy _sortStrategy;

        //Constructor with provided initial strategy for Sorter
        public SorterClass(ISortStrategy sortStrategy) {
        _sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(ISortStrategy sortStrategy){
            _sortStrategy = sortStrategy;
        }
        public void SortAndPrint()
        {
            //
            List<string> listToSort = new List<string>() { "c", "d", "a", "b", "e" };

            List<string> sortedList = this._sortStrategy.SortList(listToSort);

            Console.WriteLine(string.Join(", ", sortedList));

        }
    }
}
