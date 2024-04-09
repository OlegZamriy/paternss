 using paternss;
using System;

class Program
{
    static void Main()
    {
        Context context = new Context(new ConcreteStrategyA());
        context.ExecuteAlgorithm();

        context.SetStrategy(new ConcreteStrategyB());
        context.ExecuteAlgorithm();

        Console.ReadLine();
    }
}
