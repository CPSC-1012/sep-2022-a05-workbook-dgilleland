public class Rectangle
{
    // fields to hold the dimensions of
    // the rectangle
    public int Height;
    public int Width;

    // Property to calculate the area
    public int Area
    {
        get
        {
            return Height * Width;
        }
    }

    public override string ToString()
    {
        return $"{Height} high by {Width} wide";
    }
}
