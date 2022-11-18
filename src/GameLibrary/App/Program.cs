using static System.Console;
using static ConsoleIO;
using Games; // DropDeadGame
using Games.CommonObjects; // Die

List<string> players = new();
string input;
do
{
    input = Prompt("Enter a player name (blank to stop):");
    if(!string.IsNullOrWhiteSpace(input))
        players.Add(input.Trim());
}while(!string.IsNullOrWhiteSpace(input));

DropDeadGame game = new(players.ToArray());
game.TurnStarted += DisplayTurnStart;
game.RollFinished += DisplayTurnResults;
WriteLine("Drop-Dead Game Results");
WriteLine("----------------------");
game.Play();

void DisplayTurnStart(object? sender, string e)
{
    WriteLine($"{e}'s rolls:");
    WriteLine($"    Score | Rolls");
}

void DisplayTurnResults(object? sender, DropDeadTurnResult e)
{
    string rolls = string.Join(", ", e.DieRolls);
    WriteLine($"    {e.CurrentScore, 5} | {rolls}");
    if(e.TurnStatus == TurnStatus.Finished)
        WriteLine($"{e.PlayerName}'s Score: {e.CurrentScore}\n");
}