using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockOnCollision : MonoBehaviour
{    
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        WinCondition.counter--;
        Debug.Log(WinCondition.counter);
    }
}
