using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    // Time for action - animations in code
    // 1
    public int rotationSpeed = 100;
    Transform itemTransform; 

    void Start()
    {
        // 2
        itemTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // 3
        itemTransform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }
}