using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable<T> : MonoBehaviour where T : MonoBehaviour
{
    public int OnscreenDelay;

    void Start()
    {
        Destroy(this.gameObject, OnscreenDelay);
    }
}