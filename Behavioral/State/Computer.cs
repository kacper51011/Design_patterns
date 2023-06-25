using State.Interfaces;
using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Computer
    {

        //Actual state, we want it to be TurnedOff by default (included in constructor)
        public ComputerState State { get; set; } = null;
        public Computer() {
            State = new TurnedOff();
        }

        //methods which use actual state method, which works different depends on the state
        public void UseComputer ()
        {
            State.SearchInternet();
        }
        public void SwitchEnergy()
        {
            State.ClickButton(this);
        }
    }
}
