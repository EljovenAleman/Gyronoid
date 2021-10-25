using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float offset = 0;

    Rigidbody player;
    Renderer playerShader;

    public bool inControl = true;

    IPlayerController playerController;

    [SerializeField] Vector3 rotationVector;

    [SerializeField] int moveSpeed;

    Quaternion originalRotation;

    [SerializeField] int rotationResetSpeed;
    
    void Start()
    {
        playerShader = GetComponent<Renderer>();
        playerController = PlayerControllerFactory.playerController;
        player = GetComponent<Rigidbody>();
        originalRotation = player.rotation;
    }

    
    void FixedUpdate()
    {
        playerShader.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        offset += 0.01f; 

        if(Input.touchCount > 0)
        {
            Debug.Log(Input.touches[0].position);
        }
        
        if(inControl)
        {
            if (playerController.GoLeft() && transform.position.x > -7)
            {
                player.position = new Vector3(player.transform.position.x - 0.1f * moveSpeed, player.transform.position.y, player.transform.position.z);

                //player.AddForce(new Vector3(-1 * moveSpeed, 0, 0));

                player.rotation = Quaternion.Euler(rotationVector * 1);

            }
            else if (playerController.GoRight() && transform.position.x < 7)
            {
                player.position = new Vector3(player.transform.position.x + 0.1f * moveSpeed, player.transform.position.y, player.transform.position.z);

                //player.AddForce(new Vector3(1 * moveSpeed, 0, 0));

                player.rotation = Quaternion.Euler(rotationVector * -1);
            }
            else
            {
                player.velocity = Vector3.zero;

                player.transform.rotation = Quaternion.Slerp(transform.rotation, originalRotation, rotationResetSpeed);
                //player.rotation = Quaternion.FromToRotation(new Vector3(player.rotation.x, player.rotation.y, player.rotation.z), Vector3.zero);

            }
        }
        
    }
}
