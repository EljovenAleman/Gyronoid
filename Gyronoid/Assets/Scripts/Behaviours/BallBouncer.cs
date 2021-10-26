using UnityEngine;

public class BallBouncer : MonoBehaviour
{
    Vector3 lastVelocity;
    

    Rigidbody ball;
    public int bounceCounter = 0;

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
        Debug.Log(direction);


        BounceBall(speed, direction, collission);

        
         
        
        
    }

    private void BounceBall(float speed, Vector3 direction, Collision collision)
    {
        speed = SetSpeed(speed);
        direction = SetDirection(direction, collision);

        ball.velocity = direction * Mathf.Max(speed);
        
    }

    private Vector3 SetDirection(Vector3 direction, Collision collision)
    {
        if(collision.gameObject.tag == "90D")
        {
            Debug.Log("Collided with 90D");
            if(bounceCounter == 0)
            {
                direction.z = 1;
                bounceCounter++;
            }
            else if(bounceCounter == 1)
            {
                direction.z = 0;
                bounceCounter++;
            }
            else if(bounceCounter == 2)
            {
                direction.z = -1;
                bounceCounter++;
            }
            else if(bounceCounter == 3)
            {
                direction.z = 0;
                bounceCounter = 0;
            }
        }
        else if(collision.gameObject.tag == "0Z")
        {
            Debug.Log("Collided with 0Z");
            direction.z = 0;
        }
        else if (collision.gameObject.tag == "0Y")
        {
            Debug.Log("Collided with 0Y");
            direction.y = 0;
        }

        return direction;
    }

    private float SetSpeed(float speed)
    {
        if (speed >= 30)
        {
            return 30;
        }
        else
        {
            return 30;
        }
    }
}
