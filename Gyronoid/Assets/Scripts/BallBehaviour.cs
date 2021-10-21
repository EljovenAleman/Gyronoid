﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody ball;
    Rigidbody player;

    [SerializeField] int shootForce;
    public bool isBallActive = false;

    void Start()
    {
        ball = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(isBallActive == false)
        {
            ball.velocity = Vector3.zero;
            MoveWithPlayerUntilShooted();
        }
    }

    private void MoveWithPlayerUntilShooted()
    {
        ball.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.1f, player.transform.position.z);
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            isBallActive = true;
            ball.AddForce(new Vector3(player.velocity.x,shootForce,0), ForceMode.Impulse);
        }

    }
}