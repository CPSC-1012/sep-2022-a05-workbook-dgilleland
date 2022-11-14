namespace Games; // New way to declare a namespace for the following types/classes.
public class DropDeadGame
{
    // Have an array of strings for player names
    private readonly string[] PlayerNames;
    // Have an array of integers for player scores
    private readonly int[] PlayerScores;
    // I should have a constructor that gets the players
    public DropDeadGame(string[] players)
    {
        // TODO: Validation - if there's a problem, I'll be throwing an exception
        //  - Not enough players for the game (min 2)
        //  - Make sure the individual names are not "empty"

        PlayerNames = players;
        PlayerScores = new int[players.Length]; // an array the same size as the # of players
        // Each element in the array has the default value for the int data type
        // (which is zero)
    }

    public int RollDie(Die[] dice)
    {

    }
}
