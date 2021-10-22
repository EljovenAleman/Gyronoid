using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLevelLost : MonoBehaviour
{
    LoseCondition loseCondition;
        
    [SerializeField] Canvas loseCanvas;

    private void Start()
    {       
        loseCondition = FindObjectOfType<LoseCondition>();
    }

    private void Update()
    {
        if (loseCondition.gameLost == true)
        {            
            loseCanvas.enabled = true;
        }
    }
}
