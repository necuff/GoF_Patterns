using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Components
{
    public class Product
    {
        private readonly List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product parts......");
            foreach(var p in parts)
            {
                Console.WriteLine(p);
            }
        }
    }
}
