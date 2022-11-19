using static System.Console;
using static FunMath;
WriteLine("My List of Prime Numbers");

FunMath joy = new();
// Subscribe to the event
joy.FoundPrime += Report;
joy.FindPrimeNumbers();

// This is the Event Listener
void Report(object? sender, PrimeNumber e)
{
    WriteLine(e);
}