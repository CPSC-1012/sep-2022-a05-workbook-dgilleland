using Demo;
namespace _032;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Salutation walmartGreeter;
        walmartGreeter = new()
        {
            Greeting = "Welcome to Wallmart",
            Farewell = "Thank you for shopping at Wallmart!"
        };

        Salutation klingon = new()
        {
            Greeting = "nuqneH!",
            Farewell = "Qapla'!"
        };

        Console.WriteLine(walmartGreeter.SayHello());
        Console.WriteLine(klingon.SayHello());
    }
}
