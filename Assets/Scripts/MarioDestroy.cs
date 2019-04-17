using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MarioDestroy : MonoBehaviour {

    public AudioClip destroyGoomba;
    public AudioClip destroyMario;

    private void MakeSound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            MakeSound(destroyGoomba);
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            MakeSound(destroyMario);
            SceneManager.LoadScene("SampleScene");
            Destroy(gameObject);
        }
    }
}
