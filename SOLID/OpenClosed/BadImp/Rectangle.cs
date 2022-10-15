namespace Interview.SOLID.OpenClosed.BadImp;

internal class Rectangle
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double Height { get; }

    public double Width { get; }
}
