using paternss;
using System;

class Program
{
    static void Main()
    {
        ConcreteSubject newsPublisher = new ConcreteSubject();

        ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
        ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

        newsPublisher.Attach(observer1);
        newsPublisher.Attach(observer2);

        newsPublisher.PublishNews("New feature released!");
        newsPublisher.PublishNews("Important announcement!");

        newsPublisher.Detach(observer1);

        newsPublisher.PublishNews("Observer 1 unsubscribed!");

        Console.ReadLine();
    }
}
