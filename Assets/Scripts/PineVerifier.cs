using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PineVerifier : MonoBehaviour
{
    public static int pinesDown;
    private float initialY;
    public float distance;
    private bool down;
    // Start is called before the first frame update
    void Start()
    {
        pinesDown = 0;
        initialY = transform.position.y;
        down = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!down)
        {
            if (initialY - transform.position.y > distance)
            {
                down = true;
                pinesDown++;
            }
        }
    }
}
