using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1
using System.IO;

public class DataManager : MonoBehaviour, IManager
{
    private string _state;
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        _state = "Data Manager initialized..";
        Debug.Log(_state);

        // 2
        Debug.LogFormat("Path separator character: {0}", Path.PathSeparator);
        Debug.LogFormat("Directory separator character: {0}", Path.DirectorySeparatorChar);

        // 3
        Debug.LogFormat("Current directory: {0}", Directory.GetCurrentDirectory());
        Debug.LogFormat("Temporary path: {0}", Path.GetTempPath());
    }
}
