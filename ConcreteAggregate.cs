using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System.Collections.Generic;

    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(items);
        }
    }

}
