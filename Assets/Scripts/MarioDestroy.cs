using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarioDestroy : MonoBehaviour {

    public AudioClip destroyAudio;
    public AudioClip destroyMario;
    private AudioSource a;
    public GameObject panel;
    //public GameObject _goomba;
    private Rigidbody2D rb2D;
    public int XMovieDirection;

    private void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Unpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMovieDirection, 0));
    }

    private void MakeSound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMovieDirection, 100));

        if (collision.gameObject.tag == "head")
        //if (hit.collider.tag == "head")
        {
            //    Debug.Log("Head Destroy");
            //    Destroy(_goomba);
            //    //Destroy(FindObjectOfType<"enemy">);
            //    //GameObject xx;
            //    //xx = FindObjectOfType<"goomba">();

            rb2D.AddForce(Vector2.up * 300f);
        }
        //else if(hit.collider.tag == "enemy")
        else if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("Destroy");
            MakeSound(destroyAudio);
            Destroy(transform.gameObject);
            panel.SetActive(true);
        }
    }
}
