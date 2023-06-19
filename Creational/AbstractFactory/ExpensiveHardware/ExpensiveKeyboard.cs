using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class ExpensiveKeyboard : IKeyboard
    {
        public void GetKeyboardDetails()
        {
            Console.WriteLine("Expensive keyboard details");
        }

    }
}