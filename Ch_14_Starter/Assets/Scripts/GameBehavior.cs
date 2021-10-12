using System.Collections.Generic;
using CustomExtensions;
using UnityEngine;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour, IManager
{
    public int MaxItems;
    public Text HealthText;
    public Text ItemText;
    public Text ProgressText;
    public Button WinButton;
    public Button LossButton;
    public Stack<string> LootStack = new Stack<string>();

    public delegate void DebugDelegate(string newText);
    public DebugDelegate debug = Print;
    public PlayerBehavior playerBehavior;

    private string _state;
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    void Start()
    { 
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
        Initialize();
    }

    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            ItemText.text = "Items Collected: " + Items;

            if (_itemsCollected >= MaxItems)
            {
                WinButton.gameObject.SetActive(true);
                UpdateScene("You've found all the items!");
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " more to go!";
            }
        }
    }

    private int _playerHP = 10;
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            HealthText.text = "Player Health: " + HP;

            if (_playerHP <= 0)
            {
                LossButton.gameObject.SetActive(true);
                UpdateScene("You want another life with that?");
            }
            else
            {
                ProgressText.text = "Ouch... that's got hurt.";
            }

            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }

    public void Initialize()
    {
        _state = "Game Manager initialized..";
        _state.FancyDebug();
        Debug.Log(_state);

        LootStack.Push("Sword of Doom");
        LootStack.Push("HP Boost");
        LootStack.Push("Golden Key");
        LootStack.Push("Pair of Winged Boots");
        LootStack.Push("Mythril Bracer");

        var itemShop = new Shop<Collectable>();
        itemShop.AddItem(new Potion());
        itemShop.AddItem(new Antidote());
        Debug.Log("There are " + itemShop.GetStockCount<Potion>() + " items for sale.");

        debug(_state);
        LogWithDelegate(debug);
    }

    void OnEnable()
    {
        GameObject player = GameObject.Find("Player");
        playerBehavior = player.GetComponent<PlayerBehavior>();
        playerBehavior.playerJump += HandlePlayerJump;
        debug("Jump event subscribed...");
    }

    private void OnDisable()
    {
        playerBehavior.playerJump -= HandlePlayerJump;
        debug("Jump event unsubscribed...");
    }

    public void HandlePlayerJump()
    {
        debug("Player has jumped...");
    }

    public void PrintLootReport()
    {
        var currentItem = LootStack.Pop();
        var nextItem = LootStack.Peek();

        Debug.LogFormat("You got a {0}! You've got a good chance of finding a {1} next!", currentItem, nextItem); 
        Debug.LogFormat("There are {0} random loot items waiting for you!", LootStack.Count); 
    }

    public void UpdateScene(string updatedText)
    {
        ProgressText.text = updatedText;
        Time.timeScale = 0f;
    }

    public void RestartScene()
    {
        try
        {
            Utilities.RestartLevel(-1);
            debug("Level successfully restarted...");
        }
        catch (System.ArgumentException exception)
        {
            Utilities.RestartLevel(0);
            debug("Reverting to scene 0: " + exception.ToString());
        }
        finally
        {
            debug("Level restart has completed...");
        }
    }

    public static void Print(string newText)
    {
        Debug.Log(newText);
    }

    public void LogWithDelegate(DebugDelegate del)
    {
        del("Delegating the debug task...");
    }
}
