using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System;

    public class Leaf : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Leaf operation.");
        }
    }

}
