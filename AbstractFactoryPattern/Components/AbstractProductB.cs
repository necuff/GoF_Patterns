﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Components
{
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }
}
