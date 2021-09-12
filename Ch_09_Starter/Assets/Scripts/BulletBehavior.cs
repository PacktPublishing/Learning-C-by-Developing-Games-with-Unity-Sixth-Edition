using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float onscreenDelay = 3f;

    void Start()
    {
        Destroy(this.gameObject, onscreenDelay);
    }
}
