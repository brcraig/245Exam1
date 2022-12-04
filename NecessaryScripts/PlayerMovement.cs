/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class takes the input from input controller and uses it
 * to determine player movement
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer player;
    
    
    public void MoveLeft()
    {
        transform.position += Vector3.left;
        
    }
    public void MoveRight()
    {
        transform.position += Vector3.right;
    }
    //we use this method for clamping since position is at the center of a sprite and not the end
    private static float SpriteHalfWidth(SpriteRenderer spriteRenderer)
    {
        return spriteRenderer.sprite.rect.width / 2;
    }
}
