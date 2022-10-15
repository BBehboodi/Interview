using System;

namespace Interview.SOLID.OpenClosed.RightImp;

internal class Circle : Shape
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; }

    public override double Area()
    {
        return Radius * Radius * Math.PI;
    }
}
