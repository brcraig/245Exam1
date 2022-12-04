/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class is a child of GameState that is for the end of
 * the game when the timer runs out
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateEnded : GameState
{

    public GameStateEnded(MyGameManager manager) : base(manager){}
    
    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered End State";
        Debug.Log(stateEnteredMessage);
        gameManager.ShowCanvas("EndOfGame");
        
    }
    
    
}
