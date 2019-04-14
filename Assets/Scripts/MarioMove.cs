using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMove : MonoBehaviour
{
    public float speed = 50f;
    public float maxVelocitySpeed = 3;
    public float jumpForce = 300f;

    public float timer;
    private bool timer_start;
    public bool grounded;

    private Rigidbody2D rb2D;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        grounded = true;

        DefaultTimerSettings();
    }

    //
    void FixedUpdate()
    {
        try
        {
            PlayerMove();

            Jumping();

            TimerWork();

            rb2D.velocity = LimitedPlayerSpeed();

        }
        catch(Exception exp)
        {
            Debug.Log(exp.Message);
        }
    }

    // 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground" || collision.gameObject.tag == "wall" || 
            collision.gameObject.tag == "qm" || collision.gameObject.tag == "bricks")//Player landed to the ground
            grounded = true;

        if(collision.gameObject.tag == "mush")
        {
            IncreasePlayer();
            collision.gameObject.SetActive(false);
        }
            
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5.0f);
    }


    private void PlayerMove()
    {
        float axis_h = Input.GetAxis("Horizontal");
        rb2D.AddForce(Vector2.right * speed * axis_h);

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim.Play("Mario_Walk");
            if (Input.GetKey(KeyCode.RightArrow))
                GetComponent<SpriteRenderer>().flipX = true;
            else if (Input.GetKey(KeyCode.LeftArrow))
                GetComponent<SpriteRenderer>().flipX = false;
        }
        
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.Play("Default");
        }
            
    }


    private void Jumping()
    {
        if (Input.GetKey(KeyCode.Space) && grounded == true)
        {
            grounded = false;
            rb2D.AddForce(Vector2.up * jumpForce);
        }
    }


    private Vector2 LimitedPlayerSpeed()
    {
        if (rb2D.velocity.x > maxVelocitySpeed)
            return new Vector2(maxVelocitySpeed, rb2D.velocity.y);
        else if (rb2D.velocity.x < -maxVelocitySpeed)
            return new Vector2(-maxVelocitySpeed, rb2D.velocity.y);
        else
            return rb2D.velocity;
    }


    private void TimerWork()
    {
        if(timer_start == true)
        {
            if (timer > 0)
                timer -= Time.deltaTime;
            else if (timer <= 0)
            {
                transform.localScale = new Vector3(7, 7);
                DefaultTimerSettings();

            } 
        }
    }


    private void DefaultTimerSettings()
    {
            timer = 5f;
            timer_start = false;
    }


    private void IncreasePlayer()
    {
        if (transform.localScale.x == 10 || transform.localScale.y == 10)
            return;
        Vector3 local = transform.position;
        local.y += 1.25f;
        transform.position = local;
        StartCoroutine(Wait());


        local = new Vector3(10, 10);
        transform.localScale = local;
        timer_start = true;
    }
}
