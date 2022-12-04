/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class serves as an input controller for the player
 * that constrains movement to left and right and within
 * certain bounds with the A and D keyboard keys
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour
{
    public UnityEvent onInputLeft;
    public UnityEvent onInputRight;
    private float leftBound = -517f;
    private float rightBound = -507f;
    public SpriteRenderer spriteRenderer;
    private Vector3 spritePosition;
    private void Start()
    {
        spritePosition = transform.position;
    }
    private void Update()
    {
        GetInput();
    }
    //we did it this way in order to utilize events
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            SendMoveEvent(KeyCode.A);
        }
        if (Input.GetKey(KeyCode.D))
        {
            SendMoveEvent(KeyCode.D);
        }
    }

    private void SendMoveEvent(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case KeyCode.A:
                spritePosition.x = Mathf.Clamp(transform.position.x, leftBound, rightBound);
                onInputLeft.Invoke();
                break;
            case KeyCode.D:
                spritePosition.x = Mathf.Clamp(transform.position.x, leftBound, rightBound);
                onInputRight.Invoke();
                break;
        }
    }
}
