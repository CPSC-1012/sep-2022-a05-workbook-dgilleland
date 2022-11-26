internal class Program
{
    private static void Main(string[] args) // Entry Point
    {
        // In a Top-Level Program, you basically have only the "body" of
        // this Main method
        Console.WriteLine("Hello, World!");
        
        // Take an OOP-view of my primitive string data type
        string name; // The terms "variable" and "object" are essentially the same thing
        name = new string("Dan Gilleland");

        // Initialization Statement: declare my variable AND give it a value
        int characterCount = name.Length;
        //                       ^Field^

        bool isInstructor = name.EndsWith("Gilleland");
        //                      ^----- Method -------^  Calling the method of my variable/object
    }
}