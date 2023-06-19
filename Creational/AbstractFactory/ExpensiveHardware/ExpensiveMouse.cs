using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creational.AbstractFactory;

namespace AbstractFactory.ExpensiveHardware
{
    public class ExpensiveMouse : IMouse
    {
        public void GetMouseDetails()
        {
            Console.WriteLine("Expensive mouse details");
        }
    }
}