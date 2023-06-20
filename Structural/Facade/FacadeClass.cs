using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // Facade allow us to use all subsystems in a certain, mostly repetitive in terms of usage way
    public class FacadeClass
    {
        public void UseSubsystems()
        {
            Subsystem1 sub1 = new Subsystem1();
            Subsystem2 sub2 = new Subsystem2();
            Subsystem3 sub3 = new Subsystem3();

            // Simulation of some kind of complicated calculations
            int methodsUsage = sub1.UseSubsystem1() + sub2.UseSubsystem2() + sub3.UseSubsystem3();

            // desired result
            Console.WriteLine("all subsystems used, the returned value equals " + methodsUsage.ToString());
        }
    }
}
