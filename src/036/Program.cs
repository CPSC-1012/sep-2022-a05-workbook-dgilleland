using static System.Console;
WriteLine("Hello, World!");

// Use the Java approach
JavaLike myInfo = new();
myInfo.SetName("Dan");
myInfo.SetAge(42); // LIAR!
WriteLine($"I am {myInfo.GetName()}.");

// Use the C# approach
BetterCode yourInfo = new();
yourInfo.Name = "Stewart Dent";
yourInfo.Age = 22;
WriteLine($"You are {yourInfo.Name}.");
