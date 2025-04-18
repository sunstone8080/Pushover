using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    
    public Points score;
    public Text DisplayScore;
    public Text HighScore;
    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }


    private void Update()
    {
        DisplayScore.text = score.Score.ToString();

        if (score.Score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score.Score);
            HighScore.text = score.Score.ToString();

        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            PlayerPrefs.DeleteAll();
          
        }

    }



}
