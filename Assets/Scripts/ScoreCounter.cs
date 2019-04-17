using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Scores.get_coin();
            GameObject.Destroy(collision.gameObject);
            Debug.Log(Scores.scr);
        }
        else if (collision.gameObject.tag == "mush")
        {
            Scores.get_mushroom();
            GameObject.Destroy(collision.gameObject);
            Debug.Log(Scores.scr);
        }
    }
}

static class Scores
{
    public static int scr = 0;

    public static void get_mushroom()
    {
        scr += 1000;
    }

    public static void get_coin()
    {
        scr += 200;
    }
}
