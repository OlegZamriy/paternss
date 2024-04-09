using paternss;
using System;

class Program
{
    static void Main()
    {
        IAbstractFactory factory1 = new ConcreteFactory1();
        IProductA productA1 = factory1.CreateProductA();
        IProductB productB1 = factory1.CreateProductB();

        productA1.DisplayInfo();
        productB1.DisplayInfo();

        IAbstractFactory factory2 = new ConcreteFactory2();
        IProductA productA2 = factory2.CreateProductA();
        IProductB productB2 = factory2.CreateProductB();

        productA2.DisplayInfo();
        productB2.DisplayInfo();

        Console.ReadLine();
    }
}
