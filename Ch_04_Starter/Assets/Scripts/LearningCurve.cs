using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Time for action p. 57
    private int currentAge = 30;
    public int addedAge = 1;

    // Time for action p. 59
    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        // Time for action p. 36
        Debug.Log(30 + 1);
        Debug.Log(currentAge + 1);

        // Time for action p. 41
        ComputeAge();

        // Time for action p. 60
        Debug.Log($"A string can have variables like {firstName} inserted directly!");

        // Time for action p. 68
        //Debug.Log(firstName * pi);

        // Time for action p. 71
        //GenerateCharacter();

        // Time for action p. 74
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);

        // Time for action p. 76
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));
    }

    public int GenerateCharacter(string name, int level)
    {
        // Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        // Time for action p. 75
        return level += 5;
    }

    /// <summary>
    /// Time for action p. 45
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
