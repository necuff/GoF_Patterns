using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Components
{
    public class ConcreteProductB : Product
    {
        public override string GetType()
        {
            return "Concrete product B";
        }
    }
}
