using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Factories
{
    public class CheapHardwareFactory : IHardwareFactory
    {
        public IKeyboard CreateKeyboard()
        {
            return new CheapKeyboard();
        }

        public IMouse CreateMouse()
        {
            return new CheapMouse();
        }
    }
}