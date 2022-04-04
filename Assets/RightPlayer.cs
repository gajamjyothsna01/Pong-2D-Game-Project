using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayer : MonoBehaviour
{
    public Rigidbody2D ball;
    public Rigidbody2D rb;
    public float playerSpeed ;
    private void Awake()
    {
       // ball = GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
   
    private void FixedUpdate()
    {
        if(ball.velocity.x > 0.0f)
        {
            if (ball.position.y > transform.position.y)
            {
                rb.AddForce(Vector2.up * playerSpeed);
            }
            else if (ball.position.y < transform.position.y)
            {
                rb.AddForce(Vector2.down * playerSpeed);
            }
        }
        else
        {
            if(transform.position.y > 0.0f)
            {
                rb.AddForce(Vector2.down* playerSpeed);
            }
            else if(transform.position.y < 0.0f)
            {
                rb.AddForce(Vector2.up * playerSpeed);
            }
        }
       


    }
}
