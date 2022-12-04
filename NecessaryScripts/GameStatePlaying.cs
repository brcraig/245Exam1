/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class is a child of GameState that is for when the
 * game is actually being played
 */
using UnityEngine;
using UnityEngine.Video;

public class GameStatePlaying : GameState
{

    public GameStatePlaying(MyGameManager manager) : base(manager){}
    public override void OnMyStateEntered()
    {
        string name = "countDown";
        string stateEnteredMessage = "Entered Playing State";
        Debug.Log(stateEnteredMessage);
        gameManager.HideCanvas(name);
        gameManager.HideCanvas("mainMenu");
        gameManager.ShowCanvas("game");
    }
    
    

}
