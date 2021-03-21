using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Time for action - pausing and restarting
using UnityEngine.SceneManagement;

// Time for action - using an extension method
using CustomExtensions;

public class GameBehavior : MonoBehaviour
{
    // Time for action - creating a debug delegate
    public delegate void DebugDelegate(string newText);
    public DebugDelegate debug = Print;

    // Time for action storing collected items
    public Stack<string> lootStack = new Stack<string>();

    // Time for action - adopting an interface
    private string _state;
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    // Time for action - creating a game manager
    private int _itemsCollected = 0;
    private int _playerHP = 10;

    // Time for action - adding UI elements
    public string labelText = "Collect all 4 items and win your freedom!";
    public int maxItems = 4;

    // Time for action - winning the game
    public bool showWinScreen = false;

    // Time for action - updating the game manager
    public bool showLossScreen = false;

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

            if (_playerHP <= 0)
            {
                labelText = "You want another life with that?";
                showLossScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                labelText = "Ouch... that's got hurt.";
            }

        }
    }

    void Start()
    {
        Initialize();

        InventoryList<string> inventoryList = new InventoryList<string>();
        inventoryList.SetItem("Potion");
        Debug.Log(inventoryList.item);
    }

    public void Initialize()
    {
        _state = "Manager initialized..";
        _state.FancyDebug();
        //Debug.Log(_state);
        debug(_state);

        // Time for action - using a delegate argument
        LogWithDelegate(debug);

        // Time for action - subscribing to an event
        GameObject player = GameObject.Find("Player");
        PlayerBehavior playerBehavior = player.GetComponent<PlayerBehavior>();
        playerBehavior.playerJump += HandlePlayerJump;

        lootStack.Push("Sword of Doom");
        lootStack.Push("HP+");
        lootStack.Push("Golden Key");
        lootStack.Push("Winged Boot");
        lootStack.Push("Mythril Bracers");
    }

    public void HandlePlayerJump()
    {
        debug("Player has jumped...");
    }

    public static void Print(string newText)
    {
        Debug.Log(newText);
    }

    public void LogWithDelegate(DebugDelegate del)
    {
        del("Delegating the debug task...");
    }

    public void PrintLootReport()
    {
        // Time for action - the last item collected
        var currentItem = lootStack.Pop();
        var nextItem = lootStack.Peek();

        Debug.LogFormat("You got a {0}! You've got a good chance of finding a {1} next!", currentItem, nextItem); 
        Debug.LogFormat("There are {0} random loot items waiting for you!", lootStack.Count); 
    }   

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    void OnGUI()
    {
        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {
                Utilities.RestartLevel(0);
            }
        }

        if (showLossScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You lose..."))
            {
                Utilities.RestartLevel();
                // Utilities.RestartLeve(-1);

                // Time for action - catching restart errors
                try
                {
                    Utilities.RestartLevel(-1);
                    debug("Level restarted successfully...");
                }
                catch (System.ArgumentException e)
                {
                    Utilities.RestartLevel(0);
                    debug("Reverting to scene 0: " + e.ToString());
                }
                finally
                {
                    debug("Restart handled...");

                }
            }

            GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" + _playerHP);
            GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " + _itemsCollected);
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);
        }
    }
}
