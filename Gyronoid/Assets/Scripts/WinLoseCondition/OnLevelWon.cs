using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLevelWon : MonoBehaviour
{
    WinCondition winCondition; 

    [SerializeField] Canvas winCanvas;

    private void Start()
    {       
        winCondition = FindObjectOfType<WinCondition>();
    }

    private void Update()
    {
        if(winCondition.gameWon == true)
        {                        
            winCanvas.enabled = true;
        }
    }



}
