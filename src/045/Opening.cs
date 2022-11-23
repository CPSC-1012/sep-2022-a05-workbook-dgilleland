namespace Demo_045;

public class Opening
{
    public readonly double Width;
    public readonly double Height;

    public Opening(double width, double height)
    {
        // TODO: Validate the dimensions - must be greater than zero
        Width = width;
        Height = height;
    }

    public double area
    {
        get { return Width * Height; }
    }

    
}