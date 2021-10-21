using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReposition : MonoBehaviour
{
    BallBehaviour ball;
    

    private void Start()
    {
        ball = FindObjectOfType<BallBehaviour>();
        
    }

    private void OnTriggerEnter(Collider other)
    {        
        ball.isBallActive = false;
        Debug.Log("ball is inactive");
    }
}
