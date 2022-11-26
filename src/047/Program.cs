internal class Program
{
    private static void Main(string[] args) // Entry Point
    {
        // In a Top-Level Program, you basically have only the "body" of
        // this Main method
        Console.WriteLine("Hello, World!");
        
        // Take an OOP-view of my primitive string data type
        string name; // The terms "variable" and "object" are essentially the same thing
        //     v----- Intantiate --------v
        name = new String("Dan Gilleland");
        //         ^--- Constructor -----^
        // I am calling the constructor in order
        // to create my new String object
        // and then I store (= is the "assignment operator")
        // that object in my variable (left-hand side of the assignment operator)

        // Initialization Statement: declare my variable AND give it a value
        int characterCount = name.Length;
        //                       ^Field^

        bool isInstructor = name.EndsWith("Gilleland");
        //                      ^----- Method -------^  Calling the method of my variable/object

        // ******************* //

        MyString friendName;
        //           v----- Intantiate ------v
        friendName = new MyString("Robin Law");
        //               ^--- Constructor ---^

        characterCount = friendName.Length;
        //                         ^Field^
        
    }
}