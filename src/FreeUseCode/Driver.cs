using static System.Console;
public class Driver
{
    #region Fields and Constructor
    private MenuItem[] _MenuItems;
    private string _UserName;
    private string _FullName;
    public Driver(string username, string name, MenuItem[] menu)
    {
        _FullName = name;
        _UserName = username;
        _MenuItems = menu;
    }
    #endregion

    public void DisplayByLine()
    {
        WriteLine($"Username:  {_UserName}");
        WriteLine($"Full name: {_FullName}");
    }

    public char GetMenuChoice()
    {
        DisplayMenu();
        WriteLine();
        string result = PromptText("Enter your choice from the menu above: ");
        while(!IsValidMenuChoice(result))
        {
            result = PromptText("Enter your choice from the menu above: ");
        }
        return result[0]; // the first character
    }

    private bool IsValidMenuChoice(string choice)
    {
        bool result = false; // Start pessimistically
        // Now see if it's good
        if(choice.Length == 1)
        {
            // Loop through my menu to see if I have that item
            // Allow a match regardless of the upper/lower case
            char selection = char.ToUpper(choice[0]); // first and only character
            foreach(MenuItem item in _MenuItems)
                if(char.ToUpper(item.Identifier) == selection)
                    result = true;
        }
        return result;
    }

    public void DisplayMenu()
    {
        foreach(MenuItem item in _MenuItems)
            WriteLine(item);
    }

    public string PromptText(string message)
    {
        Write(message);
        string result = ReadLine();
        while(string.IsNullOrWhiteSpace(result))
        {
            WriteLine("Do not leave this blank!");
            result = ReadLine();
        }
        return result;
    }
    
    public decimal PromptDecimal(string message)
    {
        Write(message);
        decimal value;
        while(!decimal.TryParse(ReadLine(), out value) || value <= 0)
        {
            WriteLine("That was not a valid number.");
            Write(message);
        }

        return value;
    }

    public int PromptInt(string message)
    {
        Write(message);
        int value;
        while(!int.TryParse(ReadLine(), out value) || value <= 0)
        {
            WriteLine("That was not a valid whole number.");
            Write(message);
        }

        return value;
    }
}
// Special item: Records
//  Records are kinda like classes
public record MenuItem(char Identifier, string Text)
{
    public override string ToString()
    {
        return $"{Identifier})\t{Text}";
    }
}