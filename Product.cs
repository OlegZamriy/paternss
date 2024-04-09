using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Pizza with {Dough} dough, {Sauce} sauce, and {Topping} topping.");
        }
    }

}
