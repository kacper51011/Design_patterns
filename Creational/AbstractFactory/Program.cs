// See https://aka.ms/new-console-template for more information

using AbstractFactory.Factories;
using Creational.AbstractFactory;
using Creational.AbstractFactory.Factories;
using Creational.AbstractFactory.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        // Setting up factories, where both of them creates similar products (mouses and keyboards)
        // but with other specifications (cheap and expensive)
        IHardwareFactory cheapHardwareFactory = new CheapHardwareFactory();
        IHardwareFactory expensiveHardwareFactory = new ExpensiveHardwareFactory();


        //Creating hardware with use of cheapHardwareFactory
        IMouse cheapMouse = cheapHardwareFactory.CreateMouse();
        IKeyboard cheapKeyboard = cheapHardwareFactory.CreateKeyboard();

        //Using methods of created cheap hardwares
        cheapMouse.GetMouseDetails();
        cheapKeyboard.GetKeyboardDetails();

        //Creating hardware with use of expensiveHardwareFactory
        IMouse expensiveMouse = expensiveHardwareFactory.CreateMouse();
        IKeyboard expensiveKeyboard = expensiveHardwareFactory.CreateKeyboard();

        //Using methods of created expensive hardwares
        expensiveMouse.GetMouseDetails();
        expensiveKeyboard.GetKeyboardDetails();

        Console.ReadKey();

    }
}