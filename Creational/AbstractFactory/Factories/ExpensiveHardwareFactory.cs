using AbstractFactory.ExpensiveHardware;
using Creational.AbstractFactory;
using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class ExpensiveHardwareFactory : IHardwareFactory
    {
        public IKeyboard CreateKeyboard()
        {
            return new ExpensiveKeyboard();
        }

        public IMouse CreateMouse()
        {
            return new ExpensiveMouse();
        }
    }
}
