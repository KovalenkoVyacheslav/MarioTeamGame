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
        try
        {
            if (mario.position.x > transform.position.x)
            {
                transform.position = mario.position + relative;
            }
        }
        catch(Exception exp)
        {
            Debug.Log("Error");
        }
    }
}
