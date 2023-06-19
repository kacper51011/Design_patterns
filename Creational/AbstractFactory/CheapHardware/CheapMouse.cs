using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class CheapMouse : IMouse
    {
        public void GetMouseDetails()
        {
            Console.WriteLine("Cheap mouse details");
        }
    }
}