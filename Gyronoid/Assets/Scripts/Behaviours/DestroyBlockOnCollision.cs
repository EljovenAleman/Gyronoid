using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockOnCollision : MonoBehaviour
{
    BlockHealth blockHealth;

    private void Start()
    {
        blockHealth = GetComponent<BlockHealth>();
    }

    void OnCollisionEnter(Collision collision)
    {
        
        blockHealth.health--;
        Debug.Log(blockHealth.health);
        
        if(blockHealth.health <= 0)
        {
            Destroy(gameObject);
            WinCondition.counter--;
        }
        
        
    }
}
