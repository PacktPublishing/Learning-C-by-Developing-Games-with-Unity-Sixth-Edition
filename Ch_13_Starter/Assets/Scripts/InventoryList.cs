using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Time for action - creating a generic collection
// public class InventoryList<T>

// Time for action - limiting generic elements
public class InventoryList<T> where T : class
{
    // Time for action - adding a generic item
    private T _item;
    public T item
    {
        get { return _item; }
    }

    public void SetItem(T newItem)
    {
        _item = newItem;
        Debug.Log("New item added...");
    }

    public InventoryList()
    {
        Debug.Log("Generic list initalized...");
    }
}