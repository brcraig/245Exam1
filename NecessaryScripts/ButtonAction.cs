/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class provides that action methods that allows the game
 * manager class to move between states
 */
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    private MyGameManager myGameManager;
    public Timer timer;
    public UI ui;
    
    void Start()
    {
        myGameManager = GetComponent<MyGameManager>();
    }

    public void ActionCountDown()
    {
        Debug.Log("about to count");
        myGameManager.PublishEventToCurrentState(GameState.EventType.GameCountDown);
    }
    
    public void ActionStartGame()
    {
        Debug.Log("about to play game");
        timer.StartTimer();
        myGameManager.PublishEventToCurrentState(GameState.EventType.GamePlaying);
    }

    public void ActionEndGame()
    {
        Debug.Log("about to end game");
        ScoreKeeper.SetFinalScore(ScoreKeeper.GetScore());
        ui.ShowFinalScore();
        myGameManager.PublishEventToCurrentState(GameState.EventType.GameEnded);
    }

    public void ActionResetGame()
    {
        Debug.Log("restarting game");
        myGameManager.PublishEventToCurrentState(GameState.EventType.GameStarting); 
    }

}
