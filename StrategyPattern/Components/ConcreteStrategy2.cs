using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Components
{
    public class ConcreteStrategy2 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Algorithm 2");
        }
    }
}