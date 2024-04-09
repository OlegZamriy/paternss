using paternss;
using System;

class Program
{
    static void Main()
    {
        Creator creatorA = new ConcreteCreatorA();
        creatorA.AnOperation();

        Creator creatorB = new ConcreteCreatorB();
        creatorB.AnOperation();

        Console.ReadLine();
    }
}
