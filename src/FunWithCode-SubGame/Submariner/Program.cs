using Humanizer;
using static System.Console;
namespace Submariner;

internal class Program
{
    static void Main(string[] args)
    {
        WriteLine("Hello, World!");
        for (int count = 0; count <= 10; count++)
            WriteLine(count.ToWords());
    }
}
public class Submarine
{
    public bool IsDocked { get; private set; }
        = true;
    public int CrewComplement { get; private set; }
    public int TorpedoCount { get; private set; }
    public int Depth { get; private set; }
    public bool IsReadyForLaunch { get; private set; }
}