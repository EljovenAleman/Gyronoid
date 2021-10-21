using UnityEngine;

public class BallBouncer : MonoBehaviour
{
    Vector3 lastVelocity;
    
    Rigidbody ball;
   
    void Awake()
    {        
        ball = GetComponent<Rigidbody>();
    }

    void Update()
    {
        lastVelocity = ball.velocity;
    }

    void OnCollisionEnter(Collision collission)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collission.contacts[0].normal);

        ball.velocity = direction * Mathf.Max(speed);            
    }
}
