using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
