// See https://aka.ms/new-console-template for more information
// The newest version of C# supports Top-Level Programs.
// These top-level programs are where a single source file
// (in our case "Program.cs") can be written as a "script"
// rather than typing out the standard "boiler plate" code
// for a Program class with a Main() method.

// There are, however, some rules about organizing your code
// in a top-level file.

// 1) Any library imports must be done as the first executable
//    lines in your top-level program. For example:
using static System.Console;    // Console members can be called directly
using static System.Math;       // let's me use the Math class static members

// 2) The body of the Main() method appears next
WriteLine("Hello, World!");

// 3) Fields, properties, methods of the Program class
//    TBA

// 4) Additional classes or types
//    TBA