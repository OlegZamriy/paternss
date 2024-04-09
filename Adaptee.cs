using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System;

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee's SpecificRequest() called.");
        }
    }

}
