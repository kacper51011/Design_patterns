using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Interfaces
{
    public interface ComputerState
    {
        void ClickButton(Computer computer);
        void SearchInternet();
    }
}
