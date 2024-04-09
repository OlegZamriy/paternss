using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    public interface IProductA
    {
        void DisplayInfo();
    }

    public interface IProductB
    {
        void DisplayInfo();
    }

}
