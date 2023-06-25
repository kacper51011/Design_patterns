using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class TurnedOn : ComputerState
    {
        public void ClickButton(Computer computer)
        {
            Console.WriteLine("Turning computer off");
            computer.State = new TurnedOff();
        }

        public void SearchInternet()
        {
            Console.WriteLine("Watching random tutorials");
        }
    }
}
