/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class handles the game timer
 */
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int initMinutes = 0;
    public int minutes;
    public int initSeconds = 3;
    public int seconds;

    private string timerText;
    public ButtonAction buttonAction;


    public void StartTimer()
    {
        minutes = initMinutes;
        seconds = initSeconds;
        StartCoroutine(StartGameTime());
    }

    public void ResetTimer()
    {
        minutes = initMinutes;
        seconds = initSeconds;
    }

    public void StopTimer()
    {
        StopCoroutine(StartGameTime());
    }


    public void UpdateTimerText()
    {
        timerText = minutes.ToString() + ":" + seconds.ToString();

    }

    public string GetTime()
    {
        return timerText;
    }

    //counts down timer, takes into account only 60 seconds in a minute
    public IEnumerator StartGameTime()
    {
        while (minutes > 0 || seconds > 0)
        {
            if (seconds > 0)
            {
                seconds -= 1;
            }
            else if (minutes > 0 && seconds == 0)
            {
                minutes -= 1;
                seconds = 59;
            }

            UpdateTimerText();
            yield return new WaitForSeconds(1f);
        }
        print("timer is done");
        yield return new WaitForSeconds(1f);

        buttonAction.ActionEndGame();

    }

}
