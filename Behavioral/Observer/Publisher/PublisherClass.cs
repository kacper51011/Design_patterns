using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Publisher
{
    //Class which holds some kind of state and want to inform about its actual value
    public class PublisherClass : IPublisher
    {
        // simplified state of publisher
        // Subscribers wants to know about the actual state value
        public int State { get; set; } = 0;

        //List of subscribers, publisher need to know which objects should be notified
        //used by: NotifySubscribers
        //adding to list: RegisterSubscriber
        //removing from list: RemoveSubscriber
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        //adding object to subscriber list (must implement ISubscriber interface)
        public void RegisterSubscriber(ISubscriber subscriber)
        {
            this._subscribers.Add(subscriber);
        }

        //removing object from subscriber list
        public void RemoveSubscriber(ISubscriber subscriber)
        {
            this._subscribers.Remove(subscriber);
        }

        public void DoBusinessLogic()
        {
            Console.WriteLine("publisher is changing the state");
            this.State += 2;
            this.NotifySubscribers();
        }
    }
}
