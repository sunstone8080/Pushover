using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class pointsS : MonoBehaviour
{
  
    public Points score;
   //this is used to call the script " Points" from bame object "south Border"
   
  

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (score.ScoreOnNorth == 0)
            {
                score.Score += 1;
                score.ScoreOnNorth += 1;
            }

        }
    }
 



}
