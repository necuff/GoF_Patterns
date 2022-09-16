using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Components
{
    internal class Chebyshev : IVisitor
    {
        public void Visit(Point2D point)
        {
            var ax = Math.Abs(point.X);
            var ay = Math.Abs(point.Y);
            point.Metric = ax > ay ? ax : ay;
        }

        public void Visit(Point3D point)
        {
            var ax = Math.Abs(point.X);
            var ay = Math.Abs(point.Y);
            var az = Math.Abs(point.Z);
            var max = ax > ay ? ax : ay;
            if (max < az) max = az;
            point.Metric = max;
        }
    }
}
