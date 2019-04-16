using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rb2D_enemy;
    List<Vector3> sides = new List<Vector3> { Vector3.left, Vector3.right };
    bool state;
    //public int EnemySpeed;
    //public int XMovieDirection;

    void Start()
    {
        rb2D_enemy = GetComponent<Rigidbody2D>();
        state = true;
    }

    void FixedUpdate()
    {
    //    //RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMovieDirection, 0));
    //gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMovieDirection, 0) * EnemySpeed;
    //if (hit.distance < 0.7f)
    //{
    //    Flip();
    //    if (hit.collider.tag == "mario")
    //    {
    //        //Destroy(hit.collider.gameObject);
    //    }
    //}

    int index = state ? 1 : 0;
    transform.position += sides[index] * speed* Time.deltaTime;
    Debug.Log(transform.position.x.ToString());

    //if (gameObject.transform.position.y < -50)
    //{
    //    Destroy(gameObject);
    }


    //void Flip()
    //{
    //    if (XMovieDirection > 0)
    //    {
    //        XMovieDirection = -1;
    //    }
    //    else
    //    {
    //        XMovieDirection = 1;
    //    }

    //    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            state = !state;
            GetComponent<SpriteRenderer>().flipX = !state;
        }
    }


    /* public float speed = 3f;
    Rigidbody2D rb2D_enemy;

    List<Vector3> sides = new List<Vector3> {Vector3.left, Vector3.right };
    bool state;
    // Start is called before the first frame update
    void Start()
    {
        rb2D_enemy = GetComponent<Rigidbody2D>();
        state = true;
    }


    private void FixedUpdate()
    {
        int index = state ? 1 : 0;
        transform.position += sides[index] * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            state = !state;
            GetComponent<SpriteRenderer>().flipX = !state;
        }
    }*/
}
