﻿namespace Interview.SOLID.OpenClosed.RightImp;

internal class AreaCalculator
{
    public double TotalArea(Shape[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Area();
        }
        return area;
    }
}
