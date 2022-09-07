using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public class Composite : Component
    {        
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name)  { }

        public void Add(Component component)
        {
            children.Add(component);
        }
        
        public void Remove(Component component)
        {
            children.Remove(component);
        }


        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach(Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}