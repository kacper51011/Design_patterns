using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    // Adapter implements interface which have to be used in program
    // need method from adaptee to not reimplement whole logic or to get acces to specific information
   
    public class AdapterClass : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterClass(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        // Method which use method coming from adaptee, but do some significant changes
        public void MethodA()
        {
            _adaptee.MethodB();
            Console.WriteLine("With some changes added by adapter") ;
        }
    }
}
