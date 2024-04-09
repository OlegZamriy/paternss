using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     public class Context
    {
        public IState State { get; set; }

        public Context(IState initialState)
        {
            State = initialState;
        }

        public void Request()
        {
            State.HandleState(this);
        }
    }

}
