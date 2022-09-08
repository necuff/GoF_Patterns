using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Components
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.Write("Call Operation");
        }
    }
}