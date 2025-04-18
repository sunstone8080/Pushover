using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public float movespeed = 5f;

    public Rigidbody2D rb;

    private Vector2 movement1;

    
    void Update()
    {
         
        movement1.x = Input.GetAxisRaw("Horizontal");
        movement1.y = Input.GetAxisRaw("Vertical");
    }




    void FixedUpdate()
    {
        //movement 
        rb.MovePosition(rb.position + movement1 * movespeed * Time.fixedDeltaTime);
    }

   
   
}