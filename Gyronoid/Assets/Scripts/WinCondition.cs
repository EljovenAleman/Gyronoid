using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public bool gameWon = false;
    public static int counter = 0;

    void Awake()
    {
        var listOfBlocks = FindObjectsOfType<DestroyBlockOnCollision>();
        counter = listOfBlocks.Length;
    }

    
    void Update()
    {
        if(counter == 0)
        {
            Debug.Log("level won");
        }
    }
}
