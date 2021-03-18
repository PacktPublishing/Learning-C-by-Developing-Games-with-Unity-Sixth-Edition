using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Time for action - pausing and restarting
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    // Time for action - creating a game manager
    private int _itemsCollected = 0;
    private int _playerHP = 10;

    // Time for action - adding UI elements
    public string labelText = "Collect all 4 items and win your freedom!";
    public int maxItems = 4;

    // Time for action - winning the game
    public bool showWinScreen = false;

    // Time for action - adding backing variables
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;

            if (_itemsCollected >= maxItems)
            {
                labelText = "You've found all the items!";
                showWinScreen = true;
                Time.timeScale = 0f;
            }
            else
            {
                labelText = "Item found, only " + (maxItems - _itemsCollected) + " more to go!";
            }
        }
    }

    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }

    void OnGUI()
    {
        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100,
               Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1.0f;
            }
        }

        GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" + _playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " + _itemsCollected);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);
    }
}
