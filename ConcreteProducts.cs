using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System;

    public class ConcreteProductA : IProduct
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Product A is created.");
        }
    }

    public class ConcreteProductB : IProduct
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Product B is created.");
        }
    }

}
