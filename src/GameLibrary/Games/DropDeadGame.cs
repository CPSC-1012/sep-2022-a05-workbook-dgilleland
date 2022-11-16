﻿// New way to declare a namespace for the following types/classes, called "file-scoped namespace declaration".
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

    public void Play()
    {
        // Each player runs their turn for rolling the die
        for(int index = 0; index < PlayerNames.Length; index++)
        {
            // Game ends when the players have finished their turns
            int numberOfDie = 5;
            Die[] dice;
            do
            {
                // Create an array of die objects
                dice = new Die[numberOfDie]; // Create an array with 5 empty slots
                // Put a new die in each slot of the array
                for(int count = 0; count < dice.Length; count++)
                    dice[count] = new Die();
                
                PlayerScores[index] += RollDie(dice);
                numberOfDie = CheckRemainingDie(dice);
            }while(numberOfDie > 0);
        }
        // Then I will know the scores and can determine the winner
    }

    /// <summary>
    /// Roll all the supplied die and return an appropriate score.
    /// </summary>
    public int RollDie(Die[] dice)
    {
        int score = 0;
        foreach(Die die in dice)
            die.Roll();
        
        if(CheckRemainingDie(dice) == dice.Length)
            foreach(Die die in dice)
                score += die.FaceValue;
        return score;
    }

    /// <summary>
    /// Determines how many die can be used in the next roll (by excluding all die with face values of 2 and 5)
    /// </summary>
    public int CheckRemainingDie(Die[] dice)
    {
        int count = 0;
        foreach(Die die in dice)
            if(die.FaceValue != 2 && die.FaceValue != 5)
                count++;
        return count;
    }
}
