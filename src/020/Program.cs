namespace _020;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, World!");
    //  Namespace
    //          Class
    //                 Method
        WriteLabel("The anwer is", 42.ToString());
    }

    static void WriteLabel(string label, string value)
    {
        ForegroundColor = ConsoleColor.Cyan;
        Write(label);
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine(value);
        ResetColor();
    }
}
