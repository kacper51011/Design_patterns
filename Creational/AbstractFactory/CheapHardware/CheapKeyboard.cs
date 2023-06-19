using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class CheapKeyboard : IKeyboard
    {
        public void GetKeyboardDetails()
        {
            Console.WriteLine("Cheap keyboard details");
        }
    }
}