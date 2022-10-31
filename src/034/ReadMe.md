# Intro to Arrays

- Every console application (with its `Main()` method) will have an array of strings available to use. This array is called `args`.
  - We can pass strings to our program from the command line/terminal, as in the following example:
  
    `dotnet run -- "Dan Gilleland" 2000 All values are space-delimeted`

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Body of the main method - same as the Top-Level-Program
    }
}
```