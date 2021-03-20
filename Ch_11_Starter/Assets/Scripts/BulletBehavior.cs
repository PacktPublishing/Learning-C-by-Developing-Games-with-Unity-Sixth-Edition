using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Time for action - destroying bullets
    public float onscreenDelay = 3f;

    void Start()
    {
        Destroy(this.gameObject, onscreenDelay);
    }
}
