# Projects, Solutions, and NuGet packages

We want a program to help people learn numbers and time as English words.

Create a program that prompts the user for a number between 5 and 25. Then, loop through the numbers 1 to the value entered by the user, displaying each number translated to English. Lastly, display the current time as words.

## Setup

- From the terminal `cd` into this folder and enter `code -n .` to launch an new VS Code window
- Create a console app (`dotnet new console`) and a solution file (`dotnet new sln`)
- Add the console project to the solution
- Add the [Humanizer](https://github.com/Humanizr/Humanizer) package to the console app.
  - `dotnet add package Humanizer.Core`
