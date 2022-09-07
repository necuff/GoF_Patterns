using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }
}