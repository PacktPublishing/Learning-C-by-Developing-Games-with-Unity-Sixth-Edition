using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    // Time for action - updating item collection
    public GameBehavior gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game_Manager").GetComponent<GameBehavior>();
    }

    // Time for action - picking up an item
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item collected!");

            gameManager.Items += 1;
            gameManager.PrintLootReport();
        }
    }
}
