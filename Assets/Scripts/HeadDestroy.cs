using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDestroy : MonoBehaviour
{

    public AudioClip destroyAudio;

    private void MakeSound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "mario")
        //{
        //    Debug.Log("delete head");
        //    MakeSound(destroyAudio);
        //    Destroy(transform.parent.gameObject);
        //}
    }
}
