using paternss;
using System;

class Program
{      
    static void Main()
    {
        Singleton singletonInstance = Singleton.Instance;
        singletonInstance.SomeMethod();


        Console.ReadLine();
    }
}
