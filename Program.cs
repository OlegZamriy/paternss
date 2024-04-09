using paternss;
using System;

class Program
{
    static void Main()
    {
        ConcreteAggregate<int> aggregate = new ConcreteAggregate<int>();
        aggregate.AddItem(1);
        aggregate.AddItem(2);
        aggregate.AddItem(3);

        IIterator<int> iterator = aggregate.CreateIterator();

        while (iterator.HasNext())
        {
            int item = iterator.Next();
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}
