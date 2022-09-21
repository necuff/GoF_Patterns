using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    public interface IBuilder
    {
        public void BuildPartA();
        public void BuildPartB();
        public Product GetResult();
    }
}
