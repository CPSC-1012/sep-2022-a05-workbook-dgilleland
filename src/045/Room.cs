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
}