namespace Interview.SOLID.OpenClosed.RightImp;

internal class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double Height { get; }

    public double Width { get; }

    public override double Area()
    {
        return Height * Width;
    }
}
