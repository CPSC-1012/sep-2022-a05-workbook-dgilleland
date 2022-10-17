using static System.Console;
using Humanizer;
namespace Tutor;
class Program
{
    static void Main(string[] args)
    {
        WriteLine("Hello, Tutor!");

        int number;
        Write("Enter a number from 5 to 25: ");
        while(!int.TryParse(ReadLine(), out number) || number < 5 || number > 25)
        {
            // Retry getting a good value from the user
            WriteLine("That is not a valid number.");
            Write("Enter a number from 5 to 25: ");
        }
        WriteLine($"Here are the numbers from 1 to {number}: ");
        for(int count = 1; count <= number; count++)
        {
            WriteLine($"\t{count.ToOrdinalWords()}:   \t{count.ToWords()}");
        }
        WriteLine($"I paid {3800.ToWords()} (CAD) to learn how to do this.");

        DateTime when;
        when = DateTime.Now;
        WriteLine($"The time is {when.Humanize()}");
        WriteLine($"The buses leave {when.AddHours(1).AddMinutes(12).Humanize()}");
    }
}
