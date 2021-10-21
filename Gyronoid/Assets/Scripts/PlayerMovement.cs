using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody player;

    [SerializeField] Vector3 rotationVector;

    [SerializeField] int moveSpeed;
    
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            
            player.AddForce(new Vector3(-1 * moveSpeed, 0, 0));
            
            player.rotation = Quaternion.Euler(rotationVector * 1);

        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            
            player.AddForce(new Vector3(1 * moveSpeed, 0, 0));
           
            player.rotation = Quaternion.Euler(rotationVector * -1);
        }
        else
        {
            player.velocity = Vector3.zero;
            
            player.rotation = Quaternion.FromToRotation(new Vector3(player.rotation.x, player.rotation.y, player.rotation.z), Vector3.zero);

        }
    }
}
