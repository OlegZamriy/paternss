using paternss;
using System;

class Program
{
    static void Main()
    {
        ICoffee simpleCoffee = new SimpleCoffee();
        Console.WriteLine($"Cost: {simpleCoffee.GetCost()}, Description: {simpleCoffee.GetDescription()}");

        ICoffee coffeeWithMilk = new MilkDecorator(simpleCoffee);
        Console.WriteLine($"Cost: {coffeeWithMilk.GetCost()}, Description: {coffeeWithMilk.GetDescription()}");

        ICoffee coffeeWithMilkAndSugar = new SugarDecorator(coffeeWithMilk);
        Console.WriteLine($"Cost: {coffeeWithMilkAndSugar.GetCost()}, Description: {coffeeWithMilkAndSugar.GetDescription()}");

        Console.ReadLine();
    }
}
