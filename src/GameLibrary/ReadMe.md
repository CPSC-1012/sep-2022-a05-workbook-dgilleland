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


## Common Game Objects

There are a number of common game objects that we will be adding to this project.

### Die Object

This represents a simple 6-sided die. It uses a static (*shared*) `Random` object for generating realistic random numbers. Create a folder in the class library called "CommonObjects" and add a class file named "Die.cs". Place the following code inside that file.

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

### Player Object

> *TBA*

## Dice Related Games

**Drop Dead**
: *"Five dice and paper to record players' scores are all that is needed. A player rolls the five dice and if the throw does not include a 2 or 5, they receive the score of the total numbers added together. That player is also able to roll the dice again. When a player rolls the dice and any of them contain a 2 or 5, they score no points and the dice that includes a 2 or 5 is excluded from any future throws that they make. A player's turn does not stop until their last remaining die shows a 2 or 5. At that point, the player "drops dead" and it becomes the next player's turn. The highest total score wins."* (source: [*Drop Dead*](https://en.wikipedia.org/wiki/Drop_Dead_(dice_game)))

As a game, *Drop Dead* will have certain characteristics.

- This game is for two or more **players**. (`Player.cs`)
- In the game, we will need to manage the player's **scores** (`int[]`). 
- The game is *turn-based*, meaning that each player takes a *turn* (`.StartTurn()`) at rolling dice.
  - The rules for each turn are fixed and do not require any decisions on the part of the players.
    - Loop until I have no more die left to roll
    - `int CheckRemainingDie(Die[] dice)` - return how many die I can roll the next time
    - `int RollDie(Die[] dice)` - returns the score from rolling the die
- Once a player's turn is finished, the game continues on with the next player until all the players have had their turn at rolling the dice.
- The winning condition is simply that the player with the highest score wins the game.
- Conceivably, the game could end in a tie.

Since the game ends with a simple comparison of the player's scores, it makes sense to display each player's name with their final score. It also makes sense that the game itself should be able to identify who the winner is.

What is not stipulated in the game's instructions is how the game's *progress* should be expressed. Do we show the results of each roll, or simply the end result of the game? Will we want to pause the game at any point (such as when a player is about to start their turn, or maybe when the player's turn is finished)?

It is tempting to begin thinking that we might want to sprinkle a little bit of console I/O inside of the game itself, but **we should resist that temptation**. After all, we may want our game to be portable to other environments (a website or a mobile phone, perhaps). In any case, the *execution* of the game is a separate concern from the *presentation* of the game.

## UI Considerations

The user interface will be terminal-based. To allow the terminal to access the game library, we must add a **project reference** connecting the game library to the console application.

```powershell
# From within the App folder, run the following command
dotnet add reference ../Games/Games.csproj
```


