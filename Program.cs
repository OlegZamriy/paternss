using paternss;
using System;

class Program
{
    static void Main()
    {
        Adaptee adaptee = new Adaptee();
        ITarget adapter = new Adapter(adaptee);

        adapter.Request();

        Console.ReadLine();
    }
}
