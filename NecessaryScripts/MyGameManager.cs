/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class serves as a manager for all the various canvases, states, and
 * events in the game. Also contains countdown methods
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    public Text textCountDown;
    public int countDownTime;
    public ButtonAction buttonAction;
    public GameObject canvasMainMenuScreen;
    public GameObject canvasCountDownScreen;
    public GameObject canvasGame;
    public GameObject canvasEndOfGame;

    [HideInInspector]public GameStateStarting gameStateStarting;
    [HideInInspector]public GameStateCountDown gameStateCountDown;
    [HideInInspector]public GameStatePlaying gameStatePlaying;
    [HideInInspector]public GameStateEnded gameStateEnded;
    [HideInInspector] GameState currState;

    public Timer timer;
    public ScoreKeeper scoreKeeer;
    public StarPlacer starPlacer;

    private void Awake()
    {
        gameStateStarting = new GameStateStarting(this);
        gameStateCountDown = new GameStateCountDown(this);
        gameStatePlaying = new GameStatePlaying(this);
        gameStateEnded = new GameStateEnded(this);

    }
    private void Start()
    {
        NewGameState(gameStateStarting);
    }

    public void Update()
    {
        if (currState != null)
        {
            currState.StateUpdate();
        }
    }

    public void Reset()
    {
        Debug.Log("resetting");
        timer.ResetTimer();
        scoreKeeer.ResetScore();
        ResetCountdown();
        starPlacer.ResetStars();
    }
    public void NewGameState(GameState newState)
    {
        if (currState != null)
        {
            currState.OnMyStateExit();
        }
        currState = newState;
        currState.OnMyStateEntered();
    }

    public GameState GetCurrState()
    {
        return currState;
    }

    public void PublishEventToCurrentState(GameState.EventType eventType)
    {
        currState.OnEventRecieved(eventType);
    }

    //this is so we can show the current canvas
    public void ShowCanvas(string canvasName)
    {
        switch (canvasName)
        {
            case ("mainMenu"):
                canvasMainMenuScreen.SetActive(true);
                break;
            case("countDown"):
                canvasCountDownScreen.SetActive(true);
                break;
            case ("game"):
                canvasGame.SetActive(true);
                break;
            case("EndOfGame"):
                starPlacer.StopStars();
                canvasEndOfGame.SetActive(true);
                break;
        }
    }
    //this is so we can hide all canvases unrelated to our current state
    public void HideCanvas(string canvasName)
    {
        switch (canvasName)
        {
            case ("mainMenu"):
                canvasMainMenuScreen.SetActive(false);
                break;
            case("countDown"):
                canvasCountDownScreen.SetActive(false);
                break;
            case("EndOfGame"):
                canvasEndOfGame.SetActive(false);
                break;
            case("game"):
            {
                canvasGame.SetActive(false);
                break;
            }
        }
    }

    public void ResetCountdown()
    {
        countDownTime = 3;
    }
    public void StartCountDown()
    {
        StartCoroutine(CountDownToStart());
    }
    //counts down from 3 and says go before transitioning from 
    //countdown state to playing state
    IEnumerator CountDownToStart()
    {
        while (countDownTime > 0)
        {
            textCountDown.text = countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime--;
        }

        textCountDown.text = "GO!";

        yield return new WaitForSeconds(1f);
        
        Debug.Log("said go");
        buttonAction.ActionStartGame();
    }
    
}
