using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
    using System;

    public class ConcreteStateA : IState
    {
        public void HandleState(Context context)
        {
            Console.WriteLine("Handling state A.");
            context.State = new ConcreteStateB();
        }
    }
}
