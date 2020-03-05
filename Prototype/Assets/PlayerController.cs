using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
   private Rigidbody2D rb;
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float movement = 0f;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;


    //public Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-3, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
         // anim.SetBool("running", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
            transform.localScale = new Vector2(1, 1);
          //anim.SetBool("running", true);
        }

        else
        {
            //anim.SetBool("running", false); 
        }

        //if (Input.GetKey(KeyCode.Space)) 
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, 5);

        //}
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        movement = Input.GetAxis("Horizontal");
        if (movement > 0f)
        {
            rb.velocity = new Vector2(movement * speed, rb.velocity.y);
        }
        else if (movement < 0f)
        {
            rb.velocity = new Vector2(movement * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }



}
