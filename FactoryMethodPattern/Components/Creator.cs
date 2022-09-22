using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Components
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
