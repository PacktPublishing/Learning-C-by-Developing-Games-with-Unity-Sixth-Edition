using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// IMPORTANT!
///
/// This first script will be a long one, so I've put comments to separate out each
/// Time for Action sections.
///
/// If you need to find a specific one in the book, use the table of contents and the
/// Time for Action name :)
///
/// </summary>
public class LearningCurve : MonoBehaviour
{
    // Time for action - making a variable private
    private int CurrentAge = 30;
    public int AddedAge = 1;

    // Time for action - playing with different types
    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAuthor = true;

    // Other Time for action variables
    public int CurrentGold = 32;
    int diceRoll = 7;
    int playerLives = 3;

    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;

    public string rareItem = "Relic Stone";
    string characterAction = "Attack";

    // Start is called before the first frame update
    void Start()
    {
        // Time for action - creating a variable
        Debug.Log(30 + 1);
        Debug.Log(CurrentAge + 1);

        // Time for action - creating a simple method
        ComputeAge();

        // Time for action - creating interpolated strings
        Debug.Log($"A string can have variables like {FirstName} inserted directly!");

        // Time for action - executing incorrect type operations
        //Debug.Log(FirstName * Pi);

        // Time for action - defining a simple method
        //GenerateCharacter();

        // Time for action - adding a return type
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("SPike", characterLevel);

        // Time for action - capturing return values
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));

        // Time for action - thieving prospects
        Thievery();

        // Time for action - reaching the treasure
        OpenTreasureChamber();

        // Time for action - choosing an action
        PrintCharacterAction();

        // Time for action - rolling the dice
        RollDice();

        // Time for action - party members
        List<string> questPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        // Time for action - setting up an inventory
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5 },
            { "Antidote", 7 },
            { "AsPirin", 1 }
        };
        Debug.LogFormat("Items: {0}", itemInventory.Count);

        // Time for action - finding an element
        FindPartyMember();

        // Time for action - tracking player lives
        HealthStatus();
    }

    public void HealthStatus()
    {
        while(playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }

        Debug.Log("Player KO'd...");
    }

    public void FindPartyMember()
    {
        // Time for action - party members
        List<string> questPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        for(int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);

            if(questPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }

    public void RollDice()
    {
        switch(diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }
    }

    public void PrintCharacterAction()
    {
        switch(characterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }
    }

    public void OpenTreasureChamber()
    {
        if(pureOfHeart && rareItem == "Relic Stone")
        {
            if(!hasSecretIncantation)
            {
                Debug.Log("You have the sPirit, but not the knowledge.");
            } else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        } else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }

    public void Thievery()
    {
        if(CurrentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        } else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        } else
        {
            Debug.Log("Looks like your purse is in the sweet spot :)");
        }
    }

    public int GenerateCharacter(string name, int level)
    {
        // Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        // Time for action - adding a return type
        return level += 5;
    }

    /// <summary>
    /// Time for action p. 45
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
}
