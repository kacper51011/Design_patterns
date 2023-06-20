using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    // Class that can`t be used because we need other kind of implementation
    // Adaptee is still used somewhere else so we cant modify it
    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("text coming from Adaptee");
        }
    }
}
