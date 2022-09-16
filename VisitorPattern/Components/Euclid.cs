using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Components
{
    internal class Euclid : IVisitor
    {
        public void Visit(Point2D point)
        {
            point.Metric = Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }

        public void Visit(Point3D point)
        {
            point.Metric = Math.Sqrt(point.X * point.X + point.Y * point.Y + point.Z * point.Z);
        }
    }
}
