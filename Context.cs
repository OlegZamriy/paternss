using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteAlgorithm()
        {
            strategy.ExecuteAlgorithm();
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
    }

}
