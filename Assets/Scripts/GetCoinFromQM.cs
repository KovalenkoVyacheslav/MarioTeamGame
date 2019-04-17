using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoinFromQM : MonoBehaviour
{

    public Transform _coin;
    public float y_coor;
    Vector3 endpos;
    public Sprite spr;
    SpriteRenderer rend;
    Animator anim;
    public AnimationClip clip;

    bool isCoinGo = false;

    void Start()
    {
        endpos = _coin.position + new Vector3(0, y_coor, 0);
        rend = gameObject.GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if(isCoinGo && _coin)
        {
            _coin.position = Vector3.Lerp(_coin.position, endpos, 2.5f * Time.deltaTime);
            DestroyCoin();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "mario")
        {          
            isCoinGo = true;
            anim.enabled = false;
            rend.sprite = spr;
        }
    }

    private void DestroyCoin()
    {
        if(endpos.y - _coin.position.y < 2)
        {
            isCoinGo = false;
            _coin.gameObject.SetActive(false);
        }
    }
}
