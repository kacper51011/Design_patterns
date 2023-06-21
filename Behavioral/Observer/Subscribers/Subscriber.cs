using Observer.Interfaces;
using Observer.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    internal class Subscriber : ISubscriber
    {
       

        public void Update(IPublisher publisher)
        {
            int currentState = (publisher as PublisherClass).State;
            Console.WriteLine("Subscriber: state of publisher has been updated and it equals " + currentState);
        }
    }
}
