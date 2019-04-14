using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMushFromQM : MonoBehaviour
{

    public Transform _mush;
    public float y_coor;
    Vector3 endpos;


    bool isMushGo = false;

    void Start()
    {
        endpos = _mush.position + new Vector3(0, y_coor, 0);
    }

    void FixedUpdate()
    {
        if (isMushGo)
        {
            _mush.position = Vector3.Lerp(_mush.position, endpos, 2.5f * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mario")
        {
            isMushGo = true;
        }
    }
}
