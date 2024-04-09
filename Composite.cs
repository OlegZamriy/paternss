using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
     

    public class Composite : IComponent
    {
        private List<IComponent> children = new List<IComponent>();

        public void Add(IComponent component)
        {
            children.Add(component);
        }

        public void Remove(IComponent component)
        {
            children.Remove(component);
        }

        public void Operation()
        {
            Console.WriteLine("Composite operation:");
            foreach (var component in children)
            {
                component.Operation();
            }
        }
    }

}
