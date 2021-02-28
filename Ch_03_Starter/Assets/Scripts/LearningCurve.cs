using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Time for action p. 7
        Debug.Log(30 + 1);
        Debug.Log(currentAge + 1);

        // Time for action p. 11
        ComputeAge();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Time for action p. 17
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
