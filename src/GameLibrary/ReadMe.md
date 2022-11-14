# Game Library

To begin this application, open this folder in VS Code. The solution will consist of three projects

- A console application containing the UI and game drivers
- A class library containing the various games
- An XUnit library containing tests of the game objects

To create the solution and the related projects, run the following commands in the terminal.

```powershell
# Create a solution to contain all the projects
dotnet new sln
# Create a console application as the entry point
dotnet new console -o App -n App
# Create a class library project to hold the various games
dotnet new classlib -o Games -n Games
# Create a project to contain the tests for the various games
dotnet new xunit -o Games.Specs -n Games.Specs
# Add all three projects to the solution
dotnet sln add App/App.csproj
dotnet sln add Games/Games.csproj
dotnet sln add Games.Specs/Games.Specs.csproj
# Allow the unit test project to access the code in the class library holding the games
cd Games.Specs/
dotnet add reference ../Games/Games.csproj
```

## Dice Related Games

**Drop Dead**
: *"Five dice and paper to record players' scores are all that is needed. A player rolls the five dice and if the throw does not include a 2 or 5, they receive the score of the total numbers added together. That player is also able to roll the dice again. When a player rolls the dice and any of them contain a 2 or 5, they score no points and the dice that includes a 2 or 5 is excluded from any future throws that they make. A player's turn does not stop until their last remaining die shows a 2 or 5. At that point, the player "drops dead" and it becomes the next player's turn. The highest total score wins."* (source: [*Drop Dead*](https://en.wikipedia.org/wiki/Drop_Dead_(dice_game))) 

## UI Considerations

The user interface will be terminal-based. To allow the terminal to access the game library, we must add a **project reference** connecting the game library to the console application.

```powershell
# From within the App folder, run the following command
dotnet add reference ../Games/Games.csproj
```

## Die Object

```csharp
namespace Games.CommonObjects;

public class Die
{
    static Random _rnd = new();
    public int FaceValue { get; private set; }
    public Die()
    {
        Roll();
    }
    public void Roll()
    {
        FaceValue = _rnd.Next(1, 7);
    }
}
```

## Player Object

