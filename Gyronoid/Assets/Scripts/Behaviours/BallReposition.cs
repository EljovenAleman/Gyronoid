using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReposition : MonoBehaviour
{
    BallBehaviour ball;
    LoseCondition loseCondition;
    BallBouncer ballBouncer;

    [SerializeField] List<GameObject> livesSpheres;
    

    private void Start()
    {
        ballBouncer = FindObjectOfType<BallBouncer>();
        ball = FindObjectOfType<BallBehaviour>();
        loseCondition = FindObjectOfType<LoseCondition>();
    }

    private void OnTriggerEnter(Collider other)
    {
        RepositionBall();  
    }

    public void RepositionBall()
    {
        ball.isBallActive = false;
        ballBouncer.bounceCounter = 0;
        if (loseCondition.counter > 1)
        {
            Destroy(livesSpheres[loseCondition.counter - 2]);
        }
        loseCondition.counter--;
    }
}
