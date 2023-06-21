using Observer.Interfaces;
using Observer.Publisher;
using Observer.Subscribers;

internal class Program
{
    private static void Main(string[] args)
    {
        // Publisher object, holds the important state
        PublisherClass publisher = new PublisherClass();

        // Subscribers, which wants to know about the state
        ISubscriber sub1 = new Subscriber();
        ISubscriber sub2 = new Subscriber();
        ISubscriber sub3 = new Subscriber();

        // Registering Subscribers to be a part of a notification list
        publisher.RegisterSubscriber(sub1);
        publisher.RegisterSubscriber(sub2);
        publisher.RegisterSubscriber(sub3);

        // Imitation of business logic in publisher object
        // expected: one console line from publisher method, one console line from every subscriber(3)
        publisher.DoBusinessLogic();

        // expected: one console line from publisher method, one console line from every subscriber(3)
        publisher.DoBusinessLogic();

        // Removing one subscriber
        publisher.RemoveSubscriber(sub1);

        // expected: one console line from publisher method, one console line from every subscriber(3)
        publisher.DoBusinessLogic();

        Console.ReadKey();
    }
}