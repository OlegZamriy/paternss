using paternss;
using System;

class Program
{
    static void Main()
    {
        Sheep originalSheep = new Sheep("Dolly", 2);
        originalSheep.DisplayInfo();

        Sheep clonedSheep = (Sheep)originalSheep.Clone();
        clonedSheep.Name = "Molly";
        clonedSheep.Age = 3;
        clonedSheep.DisplayInfo();

        Console.ReadLine();
    }
}
