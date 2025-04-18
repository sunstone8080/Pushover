using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Points : MonoBehaviour
{
    public int ScoreOnNorth = 1;
    public int Score = 0;

   
    private void Start()
    {
        ScoreOnNorth = 1;
      
    }
 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (ScoreOnNorth == 1)
            {
                Score += 1;
                ScoreOnNorth -= 1;


            }
        }
    }
}