using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     public class PizzaBuilder : IBuilder
    {
        private Pizza pizza;

        public PizzaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.pizza = new Pizza();
        }

        public void BuildDough()
        {
            this.pizza.Dough = "thin";
        }

        public void BuildSauce()
        {
            this.pizza.Sauce = "tomato";
        }

        public void BuildTopping()
        {
            this.pizza.Topping = "cheese";
        }

        public Pizza GetPizza()
        {
            Pizza finishedPizza = this.pizza;
            this.Reset();
            return finishedPizza;
        }
    }

}
