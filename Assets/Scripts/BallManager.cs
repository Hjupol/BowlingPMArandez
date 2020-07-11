using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private Rigidbody ball;
    private float velocityX, velocityZ;
    private bool throwed;

    

    private void Start()
    {
        throwed = false;
        ball = null;
        SwipeDetector.OnSwipe += MoveBall;
        ball = GameObject.Find("ball").GetComponent<Rigidbody>();
    }

    private void MoveBall(SwipeData data)
    {
        if (!throwed)
        {
            velocityX = data.StartPosition.x - data.EndPosition.x;
            velocityX = velocityX / 10;

            velocityZ = data.StartPosition.y - data.EndPosition.y;
            velocityZ = velocityZ / 10;

            ball.AddForce(new Vector3(velocityX, 0, velocityZ), ForceMode.Impulse);
            throwed = true;
        }
    }

    private void OnDestroy()
    {
        SwipeDetector.OnSwipe -= MoveBall;
    }
}
