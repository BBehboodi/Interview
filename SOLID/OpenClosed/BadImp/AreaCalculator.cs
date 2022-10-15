using System;

namespace Interview.SOLID.OpenClosed.BadImp;

internal class AreaCalculator
{
    public double TotalArea(object[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            switch (shape)
            {
                case Rectangle rectangle:
                    {
                        area += rectangle.Height * rectangle.Width;
                    }
                    break;
                case Circle circle:
                    {
                        area += circle.Radius * circle.Radius * Math.PI;
                    }
                    break;
                default:
                    {
                        throw new NotSupportedException(shapes.GetType().ToString());
                    }
            }
        }
        return area;
    }
}