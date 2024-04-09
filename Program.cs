 using paternss;

class Program
{
    static void Main()
    {
        Receiver receiver = new Receiver();

        ICommand commandA = new ConcreteCommandA(receiver);
        ICommand commandB = new ConcreteCommandB(receiver);

        Invoker invoker = new Invoker();

        invoker.SetCommand(commandA);
        invoker.ExecuteCommand();

        invoker.SetCommand(commandB);
        invoker.ExecuteCommand();

        Console.ReadLine();
    }
}
