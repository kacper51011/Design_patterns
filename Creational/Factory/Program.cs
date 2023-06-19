using Factory.Classes;
using Factory.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        // Using our static factory to create products
        IProduct cheapProduct = ProductFactory.createProduct("cheap");
        IProduct expensiveProduct = ProductFactory.createProduct("expensive");

        // Invoking methods of cheap product created in factory
        cheapProduct.getDetails();
        cheapProduct.getPrice();

        // Invoking methods of expensive product created in factory
        expensiveProduct.getDetails();
        expensiveProduct.getPrice();

        Console.ReadLine();
    }
}