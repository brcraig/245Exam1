/*
 * Briana Craig
 * 2394738
 * brcraig@chapman.edu
 * CPSC 245
 * Exam 1
 */
/*
 * This class serves as a tool for other classes to
 * get certain screen aspects without clogging
 * up those classes
 */
using UnityEngine;

public static class ScreenPositionTools
{
    //we use this to get a sport for a star to spawn
    public static Vector3 RandomScreenLocation()
    {
        float randomX = Random.Range(0, Screen.width);
        float randomY = Random.Range(0, Screen.height);

        return new Vector3(randomX, randomY, 10);
    }

    public static Vector3 RandomWorldLocation()
    {
        Vector3 randomScreenLocation = RandomScreenLocation();
        return Camera.main.ScreenToWorldPoint(randomScreenLocation);
    }
    //we use this so stars won't spawn near the bottom and be unable to catch
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