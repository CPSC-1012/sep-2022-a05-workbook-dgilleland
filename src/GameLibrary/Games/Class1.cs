// New way to declare a namespace for the following types/classes, called "file-scoped namespace declaration".
namespace Games;
using Games.CommonObjects;
public class DropDeadGame
{
    #region Fields
    // Have an array of strings for player names
    private readonly string[] PlayerNames;
    // Have an array of integers for player scores
    private readonly int[] PlayerScores;
    // I should have a constructor that gets the players
    #endregion

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

    /// <summary>
    /// Roll all the supplied die and return an appropriate score.
    /// </summary>
    public int RollDie(Die[] dice)
    {
        int score = 0;
        foreach(Die die in dice)
            die.Roll();
        bool dropDead = false;
        foreach(Die die in dice)
            if(die.FaceValue == 2 || die.FaceValue == 5)
                dropDead = true;
        if(!dropDead)
            foreach(Die die in dice)
                score += die.FaceValue;
        return score;
    }

    public int CheckRemainingDie(Die[] dice)
    {
        int count = 0;
        foreach(Die die in dice)
            if(die.FaceValue != 2 && die.FaceValue != 5)
                count++;
        return count;
    }
}
