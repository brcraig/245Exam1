/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class is a child of GameState and is for when the game first
 * starts or is reset and handles the main menu
 */
using UnityEngine;

public class GameStateStarting : GameState
{
    public GameStateStarting(MyGameManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Starting State";
        Debug.Log(stateEnteredMessage);
        gameManager.HideCanvas("game");
        gameManager.HideCanvas("countDown");
        gameManager.HideCanvas("EndOfGame");
        gameManager.ShowCanvas("mainMenu");
        gameManager.Reset();
    }
    
}
