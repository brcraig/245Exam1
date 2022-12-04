/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class controls everything that gets printed on panels
 * like timer, score, and grade
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text ScoreText;
    public Text TimerText;
    public Text FinalText;
    public Text Grade;
    public Timer timer;

    void Update()
    {
        ShowScore(ScoreKeeper.GetScore());
        ShowTime(timer.GetTime());
    }

    public void ShowFinalScore()
    {
        print("final score is" + ScoreKeeper.GetFinalScore());
        FinalText.text = "Final Score: " + ScoreKeeper.GetFinalScore() + " out of " + ScoreKeeper.GetTotal();
        Grade.text = "Your grade is a " + ScoreKeeper.GetGrade();
    }
    public void ShowScore(int score)
    {
        ScoreText.text = "Score: " + score.ToString();
    }

    public void ShowTime(string time)
    {
         TimerText.text = "Time: " + time;
    }

    public void Reset()
    {
        ShowScore(0);
        ShowTime("00:00");
    }
}
