using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Interfaces
{
    /// <summary>
    /// Base Interface for Factories
    /// </summary>
    public interface IHardwareFactory
    {
        IMouse CreateMouse();
        IKeyboard CreateKeyboard();
    }
}