using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_experimant.Components
{
    public class Folder : Component
    {
        public Folder(string name) : base(name) { }

        private List<Component> children = new List<Component>();

        public void Add(Component component)
        {
            children.Add(component);
        }

        public void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void ShowDirectory()
        {
            foreach(var c in children)
            {
                Console.Write(name + "/");
                c.ShowDirectory();
            }
        }
    }
}
