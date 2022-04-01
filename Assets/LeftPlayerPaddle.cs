using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayerPaddle : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    Vector2 direction;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S))
        {
            direction = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.A))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
        

    }
    private void FixedUpdate()
    {
        rb.AddForce(direction * playerSpeed);
    }
}
