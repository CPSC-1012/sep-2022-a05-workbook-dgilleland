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
x = \frac{-b \plusmn \sqrt{b^{2} - 4ac}}{2a}
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

(src: [The Book](https://programming-0101.github.io/TheBook/About/log-summary.html))

- Practice Calculations
  - Look at [Calculator.net](https://www.calculator.net/) for various ideas
- Homework:
  - Study the [Learning Outcome Guide Review](https://programming-0101.github.io/TheBook/About/log-summary.html) from The Book


