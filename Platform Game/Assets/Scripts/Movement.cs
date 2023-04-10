using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb2d;
    public float groundDistance = 0.2f;
   // public float move_force = 10.0f;
    private float direction = 0f;
    public float speed = 5f;
   
    //public Animator animator;

    public bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");

        if (direction >0f)
        {
            rb2d.velocity = new Vector2(direction * speed, rb2d.velocity.y);
        }

        else if(direction < 0f)
        {
            rb2d.velocity = new Vector2(direction * speed, rb2d.velocity.y);
        }

        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }



        //{
        //    rb2d.AddForce(Vector2.right * Input.GetAxis("Horizontal") * move_force * Time.deltaTime, ForceMode2D.Impulse);
        //}


        /* if (Input.GetKey(KeyCode.D))
         {
             this.transform.Translate(0.1f, 0.0f, 0.0f);
         }

         if (Input.GetKey(KeyCode.A))
         {
             this.transform.Translate(-0.1f, 0.0f, 0.0f);
         }
       */


        if (!isJumping && Input.GetKeyDown(KeyCode.Space))
        {
          //  animator.SetBool("Jump1", true);
            // Add upward force to make the character jump
            // rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            rb2d.AddForce(Vector2.up * jumpForce);
            isJumping = true;
           // animator.SetBool("Saltando", true);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            isJumping = false;
          //  animator.SetBool("Saltando", false);
        }
    }
}
