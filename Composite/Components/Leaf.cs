using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}