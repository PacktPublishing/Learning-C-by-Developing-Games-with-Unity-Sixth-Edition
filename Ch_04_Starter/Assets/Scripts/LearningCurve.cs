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
        int CharacterLevel = 32;
        int NextSkillLevel = GenerateCharacter("SPike", CharacterLevel);

        // Time for action - capturing return values
        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", CharacterLevel));
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
        Debug.Log(CurrentAge + AddedAge);
    }
}
