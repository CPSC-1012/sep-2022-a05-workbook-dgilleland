# Game Library

To begin this application, open this folder in VS Code. The solution will consist of three projects

- A console application containing the UI and game drivers
- A class library containing the various games
- An XUnit library containing tests of the game objects

To create the solution and the related projects, run the following commands in the terminal.

```powershell
dotnet new sln
dotnet new console -o App -n App
dotnet new classlib -o Games -n Games
dotnet new xunit -o Games.Specs -n Games.Specs
dotnet sln add App/App.csproj
dotnet sln add Games/Games.csproj
dotnet sln add Games.Specs/Games.Specs.csproj
```

## Dice Related Games

**Drop Dead**
: *"Five dice and paper to record players' scores are all that is needed. A player rolls the five dice and if the throw does not include a 2 or 5, they receive the score of the total numbers added together. That player is also able to roll the dice again. When a player rolls the dice and any of them contain a 2 or 5, they score no points and the dice that includes a 2 or 5 is excluded from any future throws that they make. A player's turn does not stop until their last remaining die shows a 2 or 5. At that point, the player "drops dead" and it becomes the next player's turn. The highest total score wins."* (source: [*Drop Dead*](https://en.wikipedia.org/wiki/Drop_Dead_(dice_game))) 

## UI Considerations

## Die Object

## Player Object

