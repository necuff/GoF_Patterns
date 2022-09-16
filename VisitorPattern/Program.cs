using VisitorPattern.Components;

Point p = new Point2D(1, 2);
Point p2 = new Point3D(2, 3, 3);
IVisitor v = new Chebyshev();
IVisitor v2 = new Euclid();

p.Accept(v);
Console.WriteLine(p.Metric);

p.Accept(v2);
Console.WriteLine(p.Metric);


p2.Accept(v);
Console.WriteLine(p2.Metric);

p2.Accept(v2);
Console.WriteLine(p2.Metric);