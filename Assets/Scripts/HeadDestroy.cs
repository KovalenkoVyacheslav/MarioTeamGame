using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDestroy : MonoBehaviour
{

    public AudioClip destroyAudio;
    private AudioSource a;
    public int XMovieDirection;

    private void Start() { }

    private void MakeSound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMovieDirection, 0));
        //if(hit.collider.tag == "mario")
        if (collision.gameObject.tag == "mario")
        {
            MakeSound(destroyAudio);
            Destroy(transform.parent.gameObject);
        }
    }
}
