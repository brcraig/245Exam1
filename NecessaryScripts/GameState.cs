/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class serves as a constructor to all the game states and
 * their event types with virtual methods for them to override
 */
using UnityEngine;

public class GameState : MonoBehaviour
{
    
    public enum EventType
    {
        GameStarting,
        GameCountDown,
        GamePlaying,
        GameEnded
    }

    protected MyGameManager gameManager;
    public GameState(MyGameManager manager)
    {
        gameManager = manager;
    }
    public virtual void OnMyStateEntered(){}
    public virtual void OnMyStateExit(){}
    public virtual void StateUpdate(){}

    //this method is not virtual because all states need a way to move to a new state
    //and would all have the same code
    public void OnEventRecieved(EventType eventType)
    {
        switch (eventType)
        {
            case (EventType.GameCountDown):
                gameManager.NewGameState(gameManager.gameStateCountDown);
                break;
            case (EventType.GamePlaying):
                gameManager.NewGameState(gameManager.gameStatePlaying);
                break;
            case (EventType.GameEnded):
                gameManager.NewGameState(gameManager.gameStateEnded);
                break;
            case (EventType.GameStarting):
                gameManager.NewGameState(gameManager.gameStateStarting);
                break;
        }
    }
}
