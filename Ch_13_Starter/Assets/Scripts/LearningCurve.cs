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
    private int currentAge = 30;
    public int addedAge = 1;

    // Time for action - playing with different types
    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    // Other Time for action variables
    public int currentGold = 32;
    int diceRoll = 7;
    int playerLives = 3;

    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;

    public string rareItem = "Relic Stone";
    string characterAction = "Attack";

    public Transform camTransform;
    public GameObject directionLight;
    public Transform lightTransform;

    // Start is called before the first frame update
    void Start()
    {
        // Time for action - creating a variable
        Debug.Log(30 + 1);
        Debug.Log(currentAge + 1);

        // Time for action - creating a simple method
        ComputeAge();

        // Time for action - creating interpolated strings
        Debug.Log($"A string can have variables like {firstName} inserted directly!");

        // Time for action - executing incorrect type operations
        //Debug.Log(firstName * pi);

        // Time for action - defining a simple method
        //GenerateCharacter();

        // Time for action - adding a return type
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);

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
            { "Aspirin", 1 }
        };
        Debug.LogFormat("Items: {0}", itemInventory.Count);

        // Time for action - finding an element
        FindPartyMember();

        // Time for action - tracking player lives
        HealthStatus();

        // Time for action - creating a new character
        Character hero = new Character();

        // Time for action - fleshing out character details
        //Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);

        // Time for action - specifying starting properties
        Character heroine = new Character("Agatha");
        //Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);

        // Time for action - printing out character data
        hero.PrintStatsInfo();
        heroine.PrintStatsInfo();

        // Time for action - creating a weapon struct
        Weapon huntingBow = new Weapon("Hunting Bow", 105);

        // Time for action - creating a new hero
        Character hero2 = hero;
        hero2.name = "Sir Kane the Brave";
        hero2.PrintStatsInfo();

        // Time for action - copying weapons
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        // Time for action - calling a base constructor
        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        // Time for action - accessing the current transform component
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        // Time for action - finding components on different objects
        //directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
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
                Debug.Log("You have the spirit, but not the knowledge.");
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
        if(currentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        } else if (currentGold < 15)
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
    /// Time for action - adding comments
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
