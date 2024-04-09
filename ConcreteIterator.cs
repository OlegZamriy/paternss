using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     using System.Collections.Generic;

    public class ConcreteIterator<T> : IIterator<T>
    {
        private List<T> collection;
        private int currentIndex = 0;

        public ConcreteIterator(List<T> collection)
        {
            this.collection = collection;
        }

        public bool HasNext()
        {
            return currentIndex < collection.Count;
        }

        public T Next()
        {
            T currentItem = collection[currentIndex];
            currentIndex++;
            return currentItem;
        }
    }

}
