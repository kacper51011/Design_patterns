using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class TurnedOff : ComputerState
    {
        public void ClickButton(Computer computer)
        {
            Console.WriteLine("Turning computer on");
            computer.State = new TurnedOn();
        }

        public void SearchInternet()
        {
            Console.WriteLine("Computer is turned off, you can`t use it");
        }
    }
}
