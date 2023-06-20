
using Adapter.Classes;
using Adapter.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //Adaptee object involved in creating adapter
        Adaptee adaptee = new Adaptee();
        //Adapter which implements needed interface, making use of adaptee
        ITarget adapter = new AdapterClass(adaptee);

        // Adapter methodA with changed logic from MethodB coming from adaptee
        adapter.MethodA();

        Console.ReadLine();

    }
            
}