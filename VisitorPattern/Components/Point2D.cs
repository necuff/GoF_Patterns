using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Components
{
    internal class Point2D : Point
    {
        public double X { get; }
        public double Y { get; }

        public Point2D(double x, double y)
        {
            X = x; Y = y; 
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
