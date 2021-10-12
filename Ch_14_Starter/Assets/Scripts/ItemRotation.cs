using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    public int RotationSpeed = 100;
    Transform ItemTransform; 

    void Start()
    {
        ItemTransform = this.GetComponent<Transform>();
    }

    void Update()
    {
        ItemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }
}