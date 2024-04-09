using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     public class Cook
    {
        private IBuilder builder;

        public Cook(IBuilder builder)
        {
            this.builder = builder;
        }

        public void MakePizza()
        {
            this.builder.BuildDough();
            this.builder.BuildSauce();
            this.builder.BuildTopping();
        }

        public Pizza GetPizza()
        {
            return this.builder.GetPizza();
        }
    }

}
