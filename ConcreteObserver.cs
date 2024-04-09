using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System;

    public class ConcreteObserver : IObserver
    {
        private string observerName;

        public ConcreteObserver(string name)
        {
            observerName = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Observer {observerName} received message: {message}");
        }
    }

}
