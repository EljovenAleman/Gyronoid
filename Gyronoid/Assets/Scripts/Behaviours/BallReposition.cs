using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReposition : MonoBehaviour
{
    BallBehaviour ball;
    LoseCondition loseCondition;

    [SerializeField] List<GameObject> livesSpheres;
    

    private void Start()
    {
        ball = FindObjectOfType<BallBehaviour>();
        loseCondition = FindObjectOfType<LoseCondition>();
    }

    private void OnTriggerEnter(Collider other)
    {        
        ball.isBallActive = false;
        if(loseCondition.counter > 1)
        {
            Destroy(livesSpheres[loseCondition.counter - 2]);
        }
        loseCondition.counter--;        
    }
}
