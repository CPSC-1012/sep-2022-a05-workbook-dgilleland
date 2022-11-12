# Console Input/Output

TODO:

- [x] Reuse content from [**About Console I/O** in The Book](https://programming-0101.github.io/TheBook/Teach/console-1.html)
  - [ ] More on formatting output
    - [x] Currency formatting
    - [ ] Left/Right padding of spaces
    - [ ] Other formatting
    - [ ] Link to MSDN notes
- [x] Expand by adding a follow-up section `## Input Parsing`

Console applications are often used as a means to learn how to program. In such applications, user input and output is solely text-based.

Create a console application under this folder to practice the user input/output examples in this document.

----

## User Output

Sending text to the console is done through the `Console` class' `.Write()` and `.WriteLine()` methods. Simply pass some value into the those methods, and it will be displayed on the screen.

For example, try the following:

1. Create a C# console application named **UserIO**.
1. Modify the *Program.cs* file to match the following.

    ```csharp
    Console.WriteLine("Hello World");
    Console.Write("The following text is output ");
    Console.Write("on the same line.");
    Console.WriteLine();
    ```

1. Run the program (press [[Ctrl]] + [[F5]]) and observe the output, which should look something like this:

    ```shell
    Hello World
    The following text is output on the same line.
    Press any key to continue...
    ```

### Combining Strings

In the following example, the text `"Hello "` is a **string literal** while the `name` variable holds a string **value**. 

```csharp
string name = "Dan";
Console.WriteLine("Hello " + name);
```

Notice what we have done in the last line. We can take our variable and concatenate it with the text `"Hello "` as we send the combined result to be displayed in the terminal.

```shell
Hello Dan
```

This work of "adding" strings together is called **String concatenation**.

An alternative to this approach of string concatenation is using the `string.Format()` method. The `.Format()` method works by including a "placeholder" in the string passed in as the first argument. Placeholders are written as a number inside of a set of curly braces. The number corresponds to the position of the arguments sent in after the first argument. Thus, we could have written that line as

```csharp
    Console.WriteLine(string.Format("Hello {0}", name));
```

Notice that the placeholder is `{0}`. The variable `name` is in the "zeroth" position after the literal text. (You'll have an idea later on when we talk about arrays about why we start the first position at 0 instead of 1.)

The .`WriteLine()` method has a version that allows you to get the same result without calling `string.Format()`. Basically, this version makes use of the format method internally.

```csharp
    Console.WriteLine("Hello {0}", name);
```

### String Interpolation

Since version 6 of the C# programming language, a cleaner alternative to these formatting approaches is available. It's called [**string interpolation**](https://docs.microsoft.com/dotnet/csharp/language-reference/tokens/interpolated). Using string interpolation, the code could have been written as

```csharp
    Console.WriteLine($"Hello {name}");
```

String interpolation is indicated by the dollar sign immediately preceding the literal string. This way of concatenating string values has the benefit of being easier to read and understand where variable values are being inserted into the text.

### Combining Strings and Other Data Types

All of these forms of combining strings work when using other data types as well. For example, in the following code we have a little bit of math happening with monetary values.

```csharp
double subtotal, tax, total;
subtotal = 12.60;
tax = subtotal * .05;
total = subtotal + tax;
Console.WriteLine($"The subtotal is {subtotal}, the tax is {tax}, and the total is {total}");
```

The string interpolation in the last line will output the following text. Notice how the trailing zero is dropped from the subtotal (`12.6`).

```text
The subtotal is 12.6, the tax is 0.63, and the total is 13.23
```

### Formatting Currency

If we wanted to format values as currency using string interpolation, we can add `:C` to the variables.

```csharp
double subtotal, tax, total;
subtotal = 12.60;
tax = subtotal * .05;
total = subtotal + tax;
Console.WriteLine($"The subtotal is {subtotal:C}, the tax is {tax:C}, and the total is {total:C}");
```

This will produce the following output

```text
The subtotal is $12.60, the tax is $0.63, and the total is $13.23
```

----

## User Input

User input is performed by calling the `.ReadLine()` method, which will return a string. You use the method by storing the resulting user input into a variable. The following lines capture the user's input in a string variable.

```csharp
Console.Write("Type in your name and press [Enter]: ");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);
```

Asking the user to input enter information is referred to as "prompting" the user. The text output in the code `.Write("Type in your name and press [Enter]: ")` above is called the "user prompt". To complete the "prompting", a call to `.ReadLine()` will capture the user's input.

### Parsing Input

All input from the terminal will be received as text. This includes situations when you might be asking the user to input numeric or other kinds of information. The `.ReadLine()` method always returns a `string` value.

```csharp
Console.Write("Type in your current age and press [Enter]: ");
string userInput = Console.ReadLine();
```

In order to obtain a numeric value from a string, we could use the `.Parse()` method of our numeric types. For example, taking the text in the `userInput` variable, we could obtain the age using the following line of code.

```csharp
int age;
age = int.Parse(userInput);
```

If the text cannot be converted (*parsed*) into a number, then a **FormatException** will be generated, which (if not properly dealt with) will cause the program to "crash". For example, the following code will generate an error.

```csharp
age = int.Parse("Dan");
// Unhandled exception. System.FormatException: Input string was not in a correct format.
```

The error generated has the following message: `Unhandled exception. System.FormatException: Input string was not in a correct format.`

To help with safely attempting a conversion of text to a number, there is the `.TryParse()` methods. These methods explicitly return a `true` or `false` value in the attempt to convert the text. Let's examine the following code.

```csharp
Console.Write("Type in your current age and press [Enter]: ");
string userInput = Console.ReadLine();
int age;
if(int.TryParse(userInput, out age)
    Console.WriteLine("I was able to convert your input to an integer.");
else
    Console.WriteLine("Unable to convert your input to an integer.");
Console.WriteLine($"The conversion attempt produced the number {age}.");
```

If the user supplied the value `20` at the prompt, the output would be

```text
I was able to convert your input to an integer.
The conversion attempt produced the number 20.
```

On the other hand, if the user entered the word `twenty`, then the output would be

```text
Unable to convert your input to an integer.
The conversion attempt produced the number 0.
```

If the call to `.TryParse()` was successful, the converted number is stored in the `out` variable. If the conversion is unsuccessful, then the *default* numeric value of `0` is stored in the `out` variable.

There are parsing methods for all the built-in numeric data types, such as `int`, `double` and `decimal`, as well as other built-in types like `bool`. Notice that there are no `.Parse()` or `.TryParse()` methods for the `string` data type, since there is no need to convert a string into text.

Additional types such as `System.DateTime` support these parsing methods. In the example of using `DateTime.Parse(userInput)`, the result will be a value of `2022-10-18 12:00:00 AM` for all of the following input variations.

- `10 18 2022`
- `Oct 18, 2022`
- `2022 Oct 18`
- `2022 10 18`

The `.Parse()` and `.TryParse()` methods are so [ubiquitous](https://www.merriam-webster.com/dictionary/ubiquitous) that you will find them on data types created outside the .NET framework. Later on, we'll examine how to create a `Fraction` class that can convert text such as `3/4` into a `Fraction` object.
