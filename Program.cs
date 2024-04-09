 using paternss;

class Program
{
    static void Main()
    {
        Leaf leaf1 = new Leaf();
        Leaf leaf2 = new Leaf();

        Composite composite = new Composite();
        composite.Add(leaf1);
        composite.Add(leaf2);

        composite.Operation();

        Console.ReadLine();
    }
}
