using Strategy.Interfaces;
using Strategy.Sorter;
using Strategy.SortStrategies;

internal class Program
{
    private static void Main(string[] args)
    {
        //objects with ISortStrategy interfaces (strategies)
        ISortStrategy sortStrategy = new SortStrategy();
        ISortStrategy sortReverseStrategy = new SortReverseStrategy();

        // Object which use one of sort strategies passed to constructor
        SorterClass sorter = new SorterClass(sortStrategy);

        //method with SortStrategy (prints sorted list)
        sorter.SortAndPrint();

        //Setting other sort strategy which means the "SortAndPrint" Method will behave differently
        sorter.SetSortStrategy(sortReverseStrategy);

        //method with SortReverseStrategy (prints sorted and reversed list)
        sorter.SortAndPrint();

        Console.ReadLine();
    }
}