using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee) { }

        public override string GetDescription()
        {
            return $"{decoratedCoffee.GetDescription()}, with milk";
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 0.5;
        }
    }

     public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee) { }

        public override string GetDescription()
        {
            return $"{decoratedCoffee.GetDescription()}, with sugar";
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 0.2;
        }
    }

}
