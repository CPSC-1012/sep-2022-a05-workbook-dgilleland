# Agenda

Here I will be making notes about what I will be teaching in class.

----

## *Early Days*

> *At the end of this topic/class, you should be able to:*
> 
> - Answer the question "What is a computer program?"
> - List the three categories of simple information
> - Compare and contrast simple (primitive) information with complex information
> - List the three ways of organizing the "flow" of instructions in a computer program
> - Define the term "keyword" as it applies to programming languages
> - Define the concepts of "syntax" and "grammar" as they apply to programming languages
> - Explain what is meant by a "case-sensitive" programming language
> - Explain what is meant by a "type-safe" or "strongly-typed" programming language
> - Explain what is meant by an "extensible" programming language
> - Define the term "identifier" as it applies to programming languages
> - Define the term "program statement" and identify how the computer recognizes a program statement
> - Identify the entry point for every computer program
> - Define the term "intrinsic data type"

> - Define the term "IDE" as it relates to software development tools
> - Create a new project in the IDE for this course
> - Perform simple output to the console using System.Console


----

## Monday, Sep 12

> *At the end of this topic/class, you should be able to:*
> 
> - Install VS Code *user installation version* on your lab computer
> - Access your student workbook from school and from home
> - Create and manage projects in your student workbook
> - Perform version control operations in VS Code

> :memo: **Side-Note:** The [Markdown Guide](https://www.markdownguide.org/) is another great resource I would recommend.

----

## Wednesday, Sep 14


> *At the end of this topic/class, you should be able to:*
> 
> - Use the `Math` class functions for common formulas and values
> - Perform arithmetic operations and calculations on numeric values
> - Perform User I/O
> - Convert textual information into numeric information (where possible)

- **Demos:**
  - [Square](https://programming-0101.github.io/TheBook/Topic/E/Examples/Square.html) calculations - given the $side$
    - $\text{area} = side^{2}$
    - $\text{perimeter} = side \cdot 4$
  - [Circle](https://programming-0101.github.io/TheBook/Topic/E/Examples/Circle.html) calculations - given the $diameter$
    - $\text{radius} = \frac{diameter}{2}$
    - $\text{circumference} = \pi \cdot diameter$
    - $\text{area} = \pi \cdot radius^{2}$
- **Practice:**
  - [**Cylinder**](https://programming-0101.github.io/TheBook/Topic/E/Practice/Cylinder.html) calculations - given the $radius$ and the $height$, find the [volume](https://www.google.com/search?q=Volume+of+a+Cylinder) and the [surface area](https://www.google.com/search?q=Surface+Area+of+a+Cylinder). The formulas are:
    - $\text{Volume of a Cylinder} = pi \cdot r^2 \cdot h$
    - $\text{Surface Area of a Cylinder} = 2 \cdot pi \cdot r^2 + 2 \cdot pi \cdot r \cdot h$
  - [**Cone**](https://programming-0101.github.io/TheBook/Topic/E/Practice/Cone.html) calculations - given the base radius $r$ and the height $h$, find the [volume](https://www.google.com/search?q=Volume+of+a+Cone) and the [surface area](https://www.google.com/search?q=Surface+Area+of+a+Cone). The formulas are:
    - $\text{Volume of a Cone} = \frac{1}{3} \cdot pi \cdot r^2 \cdot h$
    - $\text{Surface Area of a Cone} = \pi \cdot r \cdot (r + \sqrt{h^2 + r^2})$
 
----

## Friday, Sep 16


> *At the end of this topic/class, you should be able to:*
> 
> - Select your active project for OmniSharp in Visual Studio Code
> - Describe the "Prompt" algorithm and how it is implemented in C#
> - Apply `use static` statements to simplify the use of static members of common classes (such as the `Console` class)
> - Follow proper coding standards for C#
>   - e.g.: `thisIsAVariable`, `ThisIsATypeOrClassMember` and `THIS_IS_A_CONSTANT`
> - Explain how and why constants in our programs are a better alternative to "ad-hoc" literal values
> - Perform special arithmetic tasks using the Math class
>   - Rounding, Power, etc.

- **Demos:**
  - Re-write the [Cylinder](./src/005/Program.cs) and [Cone](./src/006/Program.cs) examples to `use static System.Console`
  - [Quadratic Equation](https://programming-0101.github.io/TheBook/Topic/E/Examples/QuadraticEquation.html)

$$
x = \frac{-b \pm \sqrt{b^{2} - 4ac}}{2a}
$$


### Homework - Official Git Videos

- Watch the following videos
  - [ ] [What is Version Control?](https://git-scm.com/video/what-is-version-control) Length: 05:59
  - [ ] [Get Going with Git](https://git-scm.com/video/what-is-git) Length: 04:26
  - [ ] [What is Git?](https://git-scm.com/video/get-going) Length: 08:15
  - [ ] [Quick Wins with Git](https://git-scm.com/video/quick-wins) Length: 05:06
- Check out additional recommended tutorials, books, videos, and courses from their [External Links](https://git-scm.com/doc/ext)


----

## Friday, Sep 16


> *At the end of this topic/class, you should be able to:*
> 
> - ??
> - Describe how to access and submit marked assignments in this course
> - Enable/Disable auto-committing using the the [GitDoc]() extension appropriately for marked assignments

----

## Monday, Sep 19

> *At the end of this topic/class, you should be able to:*
> 
> - Create constants in C#

----

## Wednesday, Sep 21

> *At the end of this topic/class, you should be able to:*
> 
> - Format output as currency
> - Describe and use the following intrinsic data types in a computer program: `char`, `int`, `long`, `short`, `byte`, `double`, `float`, `bool`
> - Describe and use the following data types from the `System` namespace: `DateTime`, `TimeSpan`, `DateOnly`, `TimeOnly`
> - Describe what is meant by the term "expression"
> - Explain the difference between program statements and expressions as well as how the two relate to each other
> - List the four general sets of operators in C#
> - Describe the two basic rules of using arithmetic operators that every compiler must follow.
> - Explain what is meant by "integer division" and how that can be useful in solving particular problems regarding numbers.
> - Explain the purpose of the modulus (%) operator
> - List and describe how to use the various assignment operators in C#
> - Explain the difference between binary and unary operators
> - Demonstrate understanding of operator precedence and how to override the default precedence of the arithmetic operators
> - Summarize and distinguish the rules for automatic type conversion involving arithmetic operators and the assignment operator
> - Determine the final data type for expressions involving mixed data types and type conversion
> - Describe "type casting" and explain how to use it appropriately.
> - Use Math rounding methods with arithmetic expressions to round real numbers to a specific precision
> - Define the terms Reference Type and Value Type as they apply to data types in C#
> - **Introduction to `if`/`else`**
> - **List the relational operators**

(src: [The Book](https://programming-0101.github.io/TheBook/About/log-summary.html))

- Practice Calculations
  - Look at [Calculator.net](https://www.calculator.net/) for various ideas
- Homework:
  - Study the [Learning Outcome Guide Review](https://programming-0101.github.io/TheBook/About/log-summary.html) from The Book

## Friday, Sep 23

- :bulb: [Install Markdown Preview Mermaid Support](https://marketplace.visualstudio.com/items?itemName=bierner.markdown-mermaid)
- :100: Note the [**Additional Resources** list](./docs/AdditionalResources.md).
- Slideshows:
  - [**C# Programming** - Foundational Concepts for Objects](https://programming-0101.github.io/slides/OOP-Ramp-Up/00-FoundationalConcepts.html)
  - [**A Simplified C# Grammar**](https://programming-0101.github.io/slides/OOP-Ramp-Up/01-Grammar.html)

![](./docs/images/MathGenius.jpg)

> *At the end of this topic/class, you should be able to:*
> 
> - **Complete the [Torpeodo Game](./src/008/ReadMe.md)**
> - **Describe the behaviour of [Decision Structures](./src/009/ReadMe.md) as it relates to flow control in computer programs**
>   - **Stacked If/Else**
>   - **Nested If/Else**
>   - **Case Structure**
> - **Generate random numbers**
> - **List the logical operators**
> - Use relational, logical, and arithmetic operators to construct conditional expressions
> - Demonstrate an understanding of operator precedence in conditional expressions
> - Use statement blocks to allow nesting program statements into control structures
> - Define the term "boundary condition" as it relates to if-else statements and testing
> - Identify the correct way to compare or check the contents of strings in conditional expressions
> - List and describe some of the commonly used fields and methods of the String class
> - Identify commonly used fields and methods of the String class that would typically be used in if-else statements

### Homework/Practice

- [**StockItem**](./src/010/ReadMe.md) - This program represents an item that is part of an inventory. The item has an item name, a cost and a profit margin (which can be positive or negative). By using the profit margin, it can derive the price of the item. The program can also report if the item is priced at or below cost. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/StockItem.html))*
- [**Account**](./src/011/ReadMe.md) - This program illustrates simple if structure in handling withdrawals; withdrawals are only made when the amount does not exceed the balance and the overdraft. It also identifies if the account is overdrawn. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/Account.html))*
- [**Person**](./src/012/ReadMe.md) - This adaptation of the person program checks the age of the person to see if the person's life stage is infant, toddler, preschooler, school age, or adult. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/Person.html))*
- [**Fraction**](./src/013/ReadMe.md) - This program now ensures that any negative denominators have their negative sign "moved" to the numerator. It also recognizes whether a fraction is proper (numerator less than denominator) or not and provides a method to express the fraction as a mixed number string. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/Fraction.html))*
- [**Angle**](./src/014/ReadMe.md) - This version of the Angle program includes an attribute to identify the type of the angle as either acute, right, obtuse, straight, reflex, full rotation, or undefined. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/Angle.html))*
- [**ParkingCounter**](./src/015/ReadMe.md) - This program represents a simple counter to monitor whether a parking lot is full or not; it tracks vehicles entering and leaving the parking lot and allows the counter to be reset when the lot is full or empty. This program illustrates increment and decrement operators and/or the assignment increment or assignment decrement operators. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/ParkingCounter.html))*
- [**MemoryAddress**](./src/016/ReadMe.md) - This program represents a single memory address in both its base 10 and hexadecimal value. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/MemoryAddress.html))*
- [**Color**](./src/017/ReadMe.md) - This program represents a color as three base-10 RGB values and as a single hexadecimal value. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/Color.html))*
- [**Base16**](./src/018/ReadMe.md) - This program represents an integer value as a base-16 hexadecimal number. *(Adapted from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/Base16.html))*

## Monday, Sep 26

> *At the end of this topic/class, you should be able to:*
> 
> - **Explain the purpose of exit codes for console applications**
> - **Identify how to get the exit code for the last executed program**
>   - `$?` returns `True` if the last operation succeeded, `False` if it did not
>   - `$LASTEXITCODE` returns the exit code of the last Win32 program that was run
> - Describe the "DRY" principle as it relates to writing code
> - Define the term "method" and give an example
> - Describe the [syntax of a method declaration](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html#classes-and-class-members) (aka, method implementation)
> - Describe the [syntax of a method call](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html#method-calls)

----

## Wednesday, Sep 28

> *At the end of this topic/class, you should be able to:*
>
> - Describe how to get help information from a console (CLI) application like `git` and `dotnet`
> - Describe how to create a traditional console application (Program.cs with a main method)
>   - `dotnet new console --use-program-main`
> - Describe the [syntax of the `while` and `do-while` statements](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html#while-and-do-while)
> - Describe the [syntax of the `for` and `foreach` statements](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html#for-and-for-each)
> - Explain the benfits of the `.TryParse()` methods for converting textual values to numeric values
> - Define and distinguish the terms "argument" and "parameter"
> - Create methods in a Top Level Program to assist in keeping your code "DRY"
> - Add some "bling" to your console application by changing the `ForgroundColor` and calling `ResetColor()`
> - Code [Demo 019](./src/019/ReadMe.md)
> - Code [Demo 020](./src/020/ReadMe.md)


## Monday, Oct 3

- 🎥 [40 Windows Commands You NEED To Know (in 10 minutes)](https://youtu.be/Jfvg3CS1X3A) by *Network Chuck*

**TODO:** - Ensure GitDoc is enabled for student repositories

> *At the end of this topic/class, you should be able to:*
>
> - Follow a "Labeled Output" pattern for displaying results to the user
> - Reproduce common looping algorithms such as:
>   - [**021**](./src/021/ReadMe.md) Calculate count, total and average
>   - [**022**](./src/022/ReadMe.md) Fibonacci Sequence ([without overflow](https://www.gocomics.com/calvinandhobbes/1986/11/26))

## Friday, Oct 5

**TODO:** Explore the terminal in an external window with <kbd>CTRL</kbd> + <kbd>SHIFT</kbd> + <kbd>C</kbd>

Extra Resources:

- [String Interpolation Tutorial](https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/exploration/interpolated-strings) (20 minutes)
- C# Reference Material
  - [`$` - String Interpolation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)
  - [`@` - Verbatim Identifier](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim)
  - [How to format numbers, dates, enums, and other types in .NET](https://learn.microsoft.com/en-us/dotnet/standard/base-types/formatting-types)
  - [Alignment Formatting](https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting#alignment-component)
- C# Slideshows
  - [Foundational Concepts](https://programming-0101.github.io/slides/OOP-Ramp-Up/00-FoundationalConcepts.html) (good to review once again :+1:)
  - [Grammar](https://programming-0101.github.io/slides/OOP-Ramp-Up/01-Grammar.html)
  - [Arrays](https://programming-0101.github.io/slides/OOP-Ramp-Up/05-Arrays.html)

> *At the end of this topic/class, you should be able to:*
>
> - Follow a "Labeled Output" pattern for displaying results to the user
>   - [**027**](./src/027/ReadMe.md) - Labels and Environment Variables
>     - :mortar_board: - Copy into your own workbook
> - Add a little console "bling"
>   - [**025**](./src/025/ReadMe.md) Console Explorations
>     - :mortar_board: - Copy into your own workbook
>     - *Topic Note:* the data type returned from the `.GetPosition()` method is a [Tuple](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples).
> - [*An Intro to Arrays*](https://programming-0101.github.io/slides/OOP-Ramp-Up/05-Arrays.html) Slideshow
>   - [**026**](./src/026/ReadMe.md) Formatting Output (with array data)
>     - :mortar_board: - Copy into your own workbook

## Wednesday Oct 12

> *At the end of this topic/class, you should be able to:*
>
> - Understand the [`for` loop](./src/019/ReadMe.md#comparing-for-and-while-loops) syntax
> - Reproduce common looping algorithms such as:
>   - [**023**](./src/023/ReadMe.md) Factorial value ([without overflow](https://www.gocomics.com/calvinandhobbes/1986/11/26))
>     - :book: Code with me
>   - [**024**](./src/024/ReadMe.md) 2D grid patterns (dots -> box, X, \\, and /) using nested loops
>     - :book: Code with me
> - Parsing currency values.

----

## Friday, Oct 15

**Homework:** 

- ***Read*** the overview of [Value Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types) and [Reference Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types).
- ***Preview*** my slideshow on [Simple Objects](https://programming-0101.github.io/slides/OOP-Ramp-Up/03-Objects.html)

<details>
  <summary>Where we are going now...</summary>
  - Embracing clean OOP modularization
  - Abandoning the "brute force" approach of *procedural programming* or *scripting*
    - Spaghetti code leads to increased developer insecurity as the code base grows. Nobody wants to touch the spaghetti, and then it becomes smelly and brittle as it dries and hardens over time...
</details>


> *At the end of this topic/class, you should be able to:*
>
> - [**030**](./src/030/ReadMe.md) Describe the concepts of Projects, Solutions, and NuGet packages
>   - Create the 030 folder, then `cd` into it and enter `code -n .` to launch an new VS Code window
>   - Create a console app (`dotnet new console`) and a solution file (`dotnet new sln`)
>   - Add the console project to the solution
>   - Add the [Humanizer](https://github.com/Humanizr/Humanizer) package to the console app, loop and output number as ordinal or as words, then output the time as words.
>     - `dotnet add package Humanizer.Core`
> - [**031**](./src/031/ReadMe.md) Similar to 030, but with these goals
>   - solution with three projects
>     - console named `Driver.csproj`
>     - class library named `GameWorld.csproj`
>     - xunit named `GameWorld.Specs.csproj`
>   - Simple game object - A player with a First Name, Last Name, and Date of Birth
> - Follow prescribed steps to open project subfolders in separate VS Code instances
>   - *Why?* - It can make development a bit easier because 
>       1. Omnisharp can more readily make "assumptions" about the project/solution it needs to load for our intellisense, and
>       1. We can more easily configure the project settings for debugging (`launch.json` and `tasks.json` in the .vscode folder) and we only need to do it once.
>   - **First,** launch a new VS Code window that will open a project subfolder for "easier" development
>     - E.g.: `code -n src\001` *(Note the importance of the slash being in the correct direction - a backslash)
>   - **Second,** create the projects you need (e.g.: console driver, class library, xunit project, etc.) along with a solution file (`.sln`)
>   - **Third,** configure your project in the *"run and debug"* view of the [Activity Bar](https://code.visualstudio.com/docs/getstarted/userinterface#_activity-bar)
> - Explain how to assemble/connect projects, solutions and package depdendencies using the DotNet CLI
>   - `dotnet new sln --help`
>   - `dotnet sln --help`
>   - `dotnet add --help`
> - Get help from CLI apps using the `--help` flag
>   - `dotnet new console --help`
>   - `dotnet run --help`
>   - `dotnet --help`
>   - `gh --help`
>   - `gh issue --help`
> - Begin exploring OOP by looking at the [**ABCs**](./src/ABCs/ReadMe.md)

----

## Future Topics...

- :bulb: VS Code Keyboard Shortcuts <!-- <kbd></kbd> +  -->
  - **Search Keyboard Shortcuts** - <kbd>Ctrl</kbd> + <kbd>k</kbd>, <kbd>Ctrl</kbd> + <kbd>s</kbd>
  - **Save File** - <kbd>Ctrl</kbd> + <kbd>s</kbd>
  - **Save File As** - <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>s</kbd>
  - **Save All Files** - <kbd>Ctrl</kbd> + <kbd>k</kbd>, <kbd>s</kbd>
  - **Comment selected line(s)** - <kbd>Ctrl</kbd> + <kbd>k</kbd>, <kbd>Ctrl</kbd> + <kbd>c</kbd>
  - **Uncomment selected line(s)** - <kbd>Ctrl</kbd> + <kbd>k</kbd>, <kbd>Ctrl</kbd> + <kbd>u</kbd>
  - **Switch Editor Tab** - <kbd>Ctrl</kbd> + <kbd>tab</kbd>
  - **Toggle Internal Terminal Window** - <kbd>Ctrl</kbd> + <kbd>`</kbd>
  - **Open External Terminal Window** - <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>c</kbd>
  - **Fold Code Block** - <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>[</kbd>
  - **Unfold Code Block** - <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>]</kbd>
- C# Slideshows
  - [Simple Objects](https://programming-0101.github.io/slides/OOP-Ramp-Up/03-Objects.html)
  - [Enumerations](https://programming-0101.github.io/slides/OOP-Ramp-Up/02-Enum.html)
- Writing Unit Tests
- OOP
  - *Homework*: Read [Default values of C# types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values)
  - [**D-Bugging**](./src/D-Bugging/ReadMe.md)
  - [**E-to-M**](./src/E-to-M/ReadMe.md)

