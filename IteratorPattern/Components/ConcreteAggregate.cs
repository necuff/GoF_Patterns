using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Components
{
    internal class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public override object this[int index] 
        { 
            get => _items[index]; 
            set => _items.Insert(index, value); 
        }

        public override int Count 
        { 
            get => _items.Count; 
            protected set { } 
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
