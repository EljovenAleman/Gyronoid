using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody ball;
    Rigidbody player;

    IPlayerController playerController;

    WinCondition winCondition;
    LoseCondition loseCondition;

    [SerializeField] int shootForce;
    public bool isBallActive = false;

    void Start()
    {
        winCondition = FindObjectOfType<WinCondition>();
        loseCondition = FindObjectOfType<LoseCondition>();

        playerController = PlayerControllerFactory.playerController;
        ball = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(winCondition.gameWon)
        {
            ball.velocity = Vector3.zero;
        }
        if(loseCondition.gameLost)
        {
            ball.transform.position = new Vector3(100, 0, 0);
        }
        else if(isBallActive == false)
        {
            ball.velocity = Vector3.zero;
            MoveWithPlayerUntilShooted();
        }
    }

    private void MoveWithPlayerUntilShooted()
    {
        ball.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.1f, player.transform.position.z);
        
        if(playerController.ShootBall())
        {
            isBallActive = true;
            ball.AddForce(new Vector3(player.velocity.x,shootForce,0), ForceMode.Impulse);
        }

    }
}
