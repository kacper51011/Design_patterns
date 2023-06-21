using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    // Interface which holds methods to implement as a subscriber class (without business logic)
    public interface ISubscriber
    {
        void Update(IPublisher publisher);
    }
}
