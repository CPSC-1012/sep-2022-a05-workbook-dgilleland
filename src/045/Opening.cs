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

    public double Area
    {
        get { return Width * Height; }
    }

    public static Opening Parse(string data)
    {
        // When you throw an exception in C#, the method immediatly exits.
        string[] parts = data.Split(','); // Comma-delimited data
        if(parts.Length != 2)
            throw new FormatException("Invalid opening data: Expected a comma-delimited string of two numbers.");
        double width, height;
        if(!double.TryParse(parts[0], out width) || !double.TryParse(parts[1], out height))
            throw new FormatException("Invalid opening data: Expected numeric information for the opening's dimensions (width, height)");
        return new Opening(width, height);
    }

    public override string ToString()
    {
        return $"{Width} meters X {Height} meters";
    }
}