using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_experimant.Components
{
    public class File : Component
    {
        public File(string name) : base(name) { }

        public override void ShowDirectory()
        {            
            Console.WriteLine(name);
        }
    }
}
