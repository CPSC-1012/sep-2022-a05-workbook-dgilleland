public class BetterCode // aka C#
{
    private string _Name; // backing store
    private int _Age;     // backing store
    // A property "looks like" a field in
    // terms of how we "use" it, but it
    // "works like" a method under the hood.
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    public int Age
    {
        get { return _Age; }
        set { _Age = value; }
    }
}