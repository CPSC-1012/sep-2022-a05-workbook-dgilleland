# Driver Evolution

> *"Inch by inch, anything's a cinch"*

In this article, we will explore how we can disentangle user I/O from the heart of our applications.

## A Beginner's Experience

Simple console applications are the traditional world within which most developers learn how to code. The quintessential first program is a one-liner:

```csharp
Console.WriteLine("Hello, World!");
```

The **`Console`** class in .NET is the standard text input/output tool for communicating in a terminal or shell environment.

### Pros

The up-side of using console applications is that they are simple to work with and provide quick-n-easy user I/O. That's why it's a favorite of instructors. Since it's just text input and output, it's easy to code against; it's a simple matter of `ReadLine()` and `WriteLine()`. The learner gets to enjoy the sense of interacting with their program, and the problem complexities are simple enough for the learner to gain a sense of accomplishment.

It's also all that's needed to gain a sense of beginner computing concepts:

- performing calculations (usually mathematical ones);
- simple flow-control with `if`/`switch` and looping with `while`/`do-while` and `for`/`foreach` statements, and
- elementary data structures such as arrays

### Cons

The downside is that the learner quickly encounters a "ceiling" as to how much complexity their programs can handle. When coding the program entirely in the `Main()` method or as a simple Top-Level-Program, the learner encounters the challenges of

- duplicating code for simple I/O tasks over and over again (e.g.: validating numeric input);
- organizing logic to handle complex tasks or orchestrating user interaction with the program, and
- managing new requirements in a program's behaviour

Certainly, gains can be found by creating simple **methods** for repetitive tasks like validating numeric input or isolating lengthy tasks like complex calculations. But because methods, by definition, can only explicitly return a single item, it gets confusing how to organize such methods when handling lots of interconnected information through independent primitive variables.

![Jenga Tower](./Images/Jenga-tower-falling-40079-pixahive-150x100.jpg) Eventually, the programs become very large (hundreds of lines of code inside *`Program.cs`*), and following the logic (let alone debugging) of the code gets more and more difficult. It can feel like a balancing act of interdependencies assembled like a Jenga puzzle. Just one seemingly simple change in the program's requirements can threaten the whole app to come crumbling down, requiring major re-writes of the code.

> > We, along with our students, have fallen into a trap of our own making.

The instructor senses the problem as well. In trying to teach certain flow-control logic or problem-solving concepts, the samples and problems presented to the student become heavily centered on user I/O with numerous menus and displays. As the problems become more interesting, the challenges of handling the data requirements increase. This happens, in large part, because there has been a delay in presenting classes and OOP (object-oriented-programming) concepts. Students become accustomed to thinking in terms of primitive information and managing that information in terms of user input and output; everything becomes intertwined in increasing complexity. We, along with our students, have fallen into a trap of our own making.

**What happened?** Simply put, the students were not presented with the tools to bundle together related data and computations. We haven't yet shown them classes and objects. Instead, we instructors have allowed the students to become mired in the mindset of purely linear and procedural thinking. Without those tools, it's hard to even begin imagining how to separate a complex program into manageable blocks of code.

## Separation of Concerns

One of the early things to learn in software development is the concept of the "separation of concerns". This concept refers to the notion that we don't want disparate aspects of our software to be heavily intertwined or interconnected. Rather, we want different parts of our application to be "loosely connected".

## A) Methods as Reusable Code

So that we don't have to copy/paste the same snippets of code over and over, we can create methods to 

- [ ] ReadInt()
- [ ] ReadDouble()
- [ ] ReadChar()
- [ ] ReadText()

## ?) Projects as Reusable Code

How to re-use in another project? Traditional Copy/Paste.

## ?) NuGet Packages as Reusable Code

- [ ] Roll-your-own vs use 3rd-party packages
  - [ ] [Sharprompt](https://www.nuget.org/packages/Sharprompt)

----

## Appendix

### Terminology

**Terminal** | **Shell**
: definition

**Separation of Concerns**
: definition

**Tight Coupling**
: definition


----

<style>
p > img {
  float: right;
  padding: 5px 15px;
  padding-right: 0;
}

blockquote > blockquote {
  font-size: 36px;
  line-height: 42px;
  text-align: center;
  border: 0;
  background: inherit;
  font-style: italic;
}

blockquote:has(blockquote) {
  border: 0;
  background: inherit;
}
</style>