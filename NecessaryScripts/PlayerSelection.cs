/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class is for the two buttons on the main menu
 * that either quit or start the game
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    public ButtonAction buttonAction;
    public void OnClickPlay()
    {
        Debug.Log("selected play");
        buttonAction.ActionCountDown();
    }
    
    public void OnClickQuit()
    {
        Debug.Log("selected quit");
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
