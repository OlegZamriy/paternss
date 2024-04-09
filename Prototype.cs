using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System;

    public class Sheep : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Sheep(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public ICloneable Clone()
        {
             return new Sheep(Name, Age);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Sheep: {Name}, Age: {Age}");
        }
    }

}
