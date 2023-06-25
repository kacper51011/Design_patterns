using State;

internal class Program
{
    private static void Main(string[] args)
    {
        //object of Computer class, is switched off by default
        Computer computer = new Computer();

        // We cant use computer when it`s off, expected console log from "turned off" state
        computer.UseComputer();

        // Computer state should be equal "TurnedOn" now
        computer.SwitchEnergy();

        // Trying to use Computer, it should work fine now
        computer.UseComputer();

        //turning computer off
        computer.SwitchEnergy();

        Console.ReadLine();

       
    }
}