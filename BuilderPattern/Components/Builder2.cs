using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    internal class Builder2 : IBuilder
    {
        private readonly Product product = new Product();

        public void BuildPartA()
        {
            product.Add("Part X");
        }

        public void BuildPartB()
        {
            product.Add("Part Y");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
