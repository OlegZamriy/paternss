 using paternss;
using System;

class Program
{
    static void Main()
    {
        Context context = new Context(new ConcreteStateA());

        context.Request();  
        context.Request();  

        Console.ReadLine();
    }
}
