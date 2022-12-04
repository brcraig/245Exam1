/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class is a child class of GameState that is for
 * the countdown state at the beginning of the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStateCountDown : GameState
{
    public GameStateCountDown(MyGameManager manager) : base(manager) {}
    
    public override void OnMyStateEntered()
    {
        string name = "mainMenu";
        string stateEnteredMessage = "Entered CountDown State";
        Debug.Log(stateEnteredMessage);
        gameManager.HideCanvas(name);
        gameManager.HideCanvas("game");
        gameManager.ShowCanvas("countDown");
        gameManager.StartCountDown();
    }

    
}
