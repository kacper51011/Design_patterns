using Facade;

internal class Program
{
    private static void Main(string[] args)
    {
        // Facade object with method using all subsystems and combining them
        FacadeClass facade = new FacadeClass();

        // Usage of a method with combined subsystems
        facade.UseSubsystems();

        Console.ReadLine();
    }
}