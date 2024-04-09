using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee decoratedCoffee;

        public CoffeeDecorator(ICoffee decoratedCoffee)
        {
            this.decoratedCoffee = decoratedCoffee;
        }

        public virtual string GetDescription()
        {
            return decoratedCoffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return decoratedCoffee.GetCost();
        }
    }

}
