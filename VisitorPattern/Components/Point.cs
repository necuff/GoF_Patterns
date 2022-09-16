using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Components
{
    internal abstract class Point
    {
        public double Metric { get; set; } = -1;
        public abstract void Accept(IVisitor visitor);
    }
}
