using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 3f;
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
    }
}
