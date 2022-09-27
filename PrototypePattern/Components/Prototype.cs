using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Components
{
    public abstract class Prototype
    {
        public string Id { get; private set; }
        
        public Prototype(string id)
        {
            this.Id = id;

            Console.WriteLine("Base constructor is called");
        }

        public virtual Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
