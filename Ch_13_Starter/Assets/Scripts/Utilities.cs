using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Time for action - creating a static class
using UnityEngine.SceneManagement;

public static class Utilities
{
    public static int playerDeaths = 0;

    // Time for action - tracking player restarts
    public static string UpdateDeathCount(ref int countReference)
    {
        countReference += 1;
        return "Next time you'll be at number " + countReference;
    }

    public static void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;

        Debug.Log("Player deaths: " + playerDeaths);
        string message = UpdateDeathCount(ref playerDeaths);
        Debug.Log("Player deaths: " + playerDeaths);
    }

    // Time for action - overloading the level restart
    public static bool RestartLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1.0f;

        return true;
    }
}
