using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Components
{
    internal interface IVisitor
    {
        void Visit(Point2D point);
        void Visit(Point3D point);
    }
}
