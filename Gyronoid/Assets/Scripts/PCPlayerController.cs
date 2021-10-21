using UnityEngine;

public class PCPlayerController : IPlayerController
{
    public bool GoLeft()
    {
        return Input.GetKey(KeyCode.LeftArrow);
    }

    public bool GoRight()
    {
        return Input.GetKey(KeyCode.RightArrow);
    }

    public bool ShootBall()
    {
        return Input.GetKeyDown(KeyCode.UpArrow);
    }
}

public class MobilePlayerController : IPlayerController
{
    public bool GoLeft()
    {
        if(Input.touchCount > 0)
        {
            if (Input.touches[0].position.x < 210 && Input.touches[0].phase == TouchPhase.Stationary)
            {
                return true;
            }
        }
        
        return false;
    }

    public bool GoRight()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].position.x > 210 && Input.touches[0].phase == TouchPhase.Stationary)
            {
                return true;
            }
        }
               
        return false;
    }

    public bool ShootBall()
    {

        if (Input.touchCount > 0)
        {
            if (Input.touches[0].position.y > 170 && Input.touches[0].phase == TouchPhase.Began)
            {
                return true;
            }
        }
        
        return false;
    }
}
