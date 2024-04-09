using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System;

    public class ConcreteProductA1 : IProductA
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Product A1 is created.");
        }
    }

    public class ConcreteProductA2 : IProductA
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Product A2 is created.");
        }
    }

    public class ConcreteProductB1 : IProductB
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Product B1 is created.");
        }
    }

    public class ConcreteProductB2 : IProductB
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Product B2 is created.");
        }
    }

}
