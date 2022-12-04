/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class serves as a controller for everything score related
 * including the live score, final score, and final grade
 */
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static int score;
    public static int totalObjectsSpawned;
    public static int finalScore;
    public static char finalGrade;

    public void ResetScore()
    {
        score = 0;
        totalObjectsSpawned = 0;
    }
    public static void AddToScore(int amount)
    {
        score = score + amount; 
    }

    public static int GetScore()
    {
        return score;
    }

    //sets current score to a separate final score so it 
    //can never be accidentally messed with
    public static void SetFinalScore(int final)
    {
        print("setting final score to " + final);
        finalScore = final;
        finalGrade = CalculateGrade();
        print(finalScore + " out of " + GetTotal());
    }

    public static int GetFinalScore()
    {
        return finalScore;
    }

    public static char GetGrade()
    {
        return finalGrade;
    }
    //could not use a switch case here because it only allows one case
    //and we have two cases because they are in a range
    public static char CalculateGrade()
    {
        float newFinal = (float)GetFinalScore();
        float newTotal = (float)GetTotal();
        float percent = (float)(newFinal / newTotal);
        print(percent + "percent grade");
        if (percent > 0.9f)
        {
            return 'A';
        }else if (percent < 0.9f && percent >= 0.8f)
        {
            return 'B';
        }else if (percent < 0.8f && percent >= 0.7f)
        {
            return 'C';
        }else if (percent < 0.7f && percent >= 0.6f)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
    
    public static void AddToTotal()
    {
        totalObjectsSpawned = totalObjectsSpawned + 1; 
    }

    public static int GetTotal()
    {
        return totalObjectsSpawned;
    }
}
