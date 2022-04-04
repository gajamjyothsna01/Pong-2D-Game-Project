using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody2D rb;
    int scoreL, scoreR;
    public Text scoreTextR, scoreTextL;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
       
    }
    private void AddForceToBall()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * ballSpeed);
    }
    private void AddForce(Vector2 force)
    {
        rb.AddForce(force );
    }
    // Update is called once per frame

    public void ResetPosition()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;

        AddForceToBall();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Right")
        {
            scoreL++;
            //Debug.Log(scoreL);
            scoreTextL.text = scoreL.ToString();
        }
        if (collision.gameObject.tag == "Left")
        {
            scoreR++;
           // Debug.Log(scoreR);
            scoreTextR.text = scoreR.ToString();
        }
    }


}
