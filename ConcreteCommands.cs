using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
    // ConcreteCommands.cs
    using System;

    public class ConcreteCommandA : ICommand
    {
        private Receiver receiver;

        public ConcreteCommandA(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Executing Command A");
            receiver.ActionA();
        }
    }

    public class ConcreteCommandB : ICommand
    {
        private Receiver receiver;

        public ConcreteCommandB(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Executing Command B");
            receiver.ActionB();
        }
    }

}
