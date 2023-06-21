using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    // Interface which holds methods to implement as a publisher class (without business logic)
    public interface IPublisher
    {
        void RegisterSubscriber(ISubscriber subscriber);
        void RemoveSubscriber(ISubscriber subscriber);
        void NotifySubscribers();
    }
}
