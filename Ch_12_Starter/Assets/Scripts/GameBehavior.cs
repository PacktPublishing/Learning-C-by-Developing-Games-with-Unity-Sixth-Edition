using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CustomExtensions;

public class GameBehavior : MonoBehaviour, IManager
{
    public int MaxItems;
    public Text HealthText;
    public Text ItemText;
    public Text ProgressText;
    public Button WinButton;
    public Button LossButton;
    public Stack<string> LootStack = new Stack<string>();

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
        LootStack.Push("Pair of Winged Boot");
        LootStack.Push("Mythril Bracer");
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
        Utilities.RestartLevel(0);
    }
}
