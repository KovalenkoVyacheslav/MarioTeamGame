using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowByMario : MonoBehaviour
{
    public Transform mario;
    public Vector3 relative;

    void FixedUpdate()
    {
        if (mario.position.x > transform.position.x)
        {
            transform.position = new Vector3(mario.position.x + relative.x, transform.position.y, transform.position.z);
        }
        else if (mario.position.x < transform.position.x)
        {
            transform.position = new Vector3(mario.position.x + relative.x, transform.position.y, transform.position.z);
        }

        if (mario.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, mario.position.y + relative.y, transform.position.z);
        }
        else if (mario.position.y < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, mario.position.y + relative.y, transform.position.z);

            if (mario.position.x > transform.position.x)
            {
                transform.position = mario.position + relative;
            }
        }


    }
}
