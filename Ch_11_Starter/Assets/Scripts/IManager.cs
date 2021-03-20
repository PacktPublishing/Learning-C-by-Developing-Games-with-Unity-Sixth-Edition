using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Timefor action - creating a manager interface
public interface IManager
{
    string State { get; set; }
    void Initialize();
}