using paternss;
using System;

class Program
{
    static void Main()
    {
        IBuilder pizzaBuilder = new PizzaBuilder();
        Cook cook = new Cook(pizzaBuilder);

        cook.MakePizza();
        Pizza pizza = cook.GetPizza();
        pizza.DisplayInfo();

        Console.ReadLine();
    }
}
