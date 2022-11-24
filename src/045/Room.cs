namespace Demo_045;

public class Room
{
    public readonly double Width;
    public readonly double Height;
    public readonly double Length;
    public Room(double width, double height, double length)
    {
        // TODO: Validate dimensions
        Width = width;
        Height = height;
        Length = length;
    }

    public static Room Parse(string data)
    {
        // TODO: Validation....
        string[] dimensions = data.Split(',');
        // Expect as width, length, height
        double width = double.Parse(dimensions[0]);
        double len = double.Parse(dimensions[1]);
        double high = double.Parse(dimensions[2]);
        return new Room(width, high, len);
    }

    private Opening[] _Openings = new Opening[10]; // Presume 10 openings max to begin with
    private int _LogicalSize = 0;

    public void AddOpening(Opening holeInWall)
    {
        // TODO: Things could go wrong, but we'll figure out validation later...
        _Openings[_LogicalSize] = holeInWall;
        _LogicalSize++;
    }

    public double Area
    {
        get
        {
            double roomArea = Width * Height * 2 + Length * Height * 2;
            double totalOpeningArea = 0;
            for(int index = 0; index < _LogicalSize; index++)
                totalOpeningArea += _Openings[index].Area;
            double result = roomArea - totalOpeningArea;
            return result;
        }
    }

    public override string ToString()
    {
        return $"{Width} meters X {Length} meters X {Height} meters with {_LogicalSize} openings";
    }
}