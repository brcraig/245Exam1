/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class controls where and when stars are placed
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarPlacer : MonoBehaviour
{
    public GameObject Prefab;

    private int secondsUntilNextCreation;
    //this bool is to help keep spawning of stars random
    private bool isWaitingToCreate = false;
    public ScoreKeeper ScoreKeeper;
    private bool CanCreate = true;

    // Update is called once per frame
    void Update()
    {
        if (!isWaitingToCreate && CanCreate)
        {
            secondsUntilNextCreation = Random.Range(GameParameters.StarMinimumTimeToNextCreation, GameParameters.StarMaximumTimeToNextCreation);
            isWaitingToCreate = true;
            StartCoroutine(CountdownUntilCreation());
        }
    }

    public void ResetStars()
    {
        CanCreate = true;
    }

    public void StopStars()
    {
        CanCreate = false;
    }
    IEnumerator CountdownUntilCreation()
    {
        yield return new WaitForSeconds(secondsUntilNextCreation);
        Place();
        isWaitingToCreate = false;
    }
    protected virtual void Place()
    {
        Vector3 position = RandomTopOfScreenWorldLocation();
        Instantiate(Prefab, position, Quaternion.identity);
        ScoreKeeper.AddToTotal();
    }
    public static Vector3 RandomTopOfScreenLocation()
    {
        float randomX = Random.Range(0, Screen.width);
        return new Vector3(randomX, Screen.height, 10);
    }

    public static Vector3 RandomTopOfScreenWorldLocation()
    {
        Vector3 randomTopOfScreenLocation = RandomTopOfScreenLocation();
        return Camera.main.ScreenToWorldPoint(randomTopOfScreenLocation);
    }
}
