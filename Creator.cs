using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public void AnOperation()
        {
            IProduct product = FactoryMethod();
            product.DisplayInfo();
        }
    }

}
