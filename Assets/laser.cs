using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public Rigidbody2D rb;

    float speed = 1f;

    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    public float KillTime = 1f;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);

        Destroy(gameObject, KillTime);

    }
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);

        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            speed = 25;


        }
    }



}
   






