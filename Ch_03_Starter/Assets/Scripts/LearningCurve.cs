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
    public int currentAge = 30;
    public int addedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Time for action - creating a variable
        Debug.Log(30 + 1);
        Debug.Log(currentAge + 1);

        // Time for action - creating a simple method
        ComputeAge();
    }

    // Update is called once per frame
    void Update()
    {
        
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
