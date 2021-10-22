using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public bool gameLost = false;
    public int counter = 0;

    private void Update()
    {
        if(counter == 0)
        {
            gameLost = true;
        }
    }
}
