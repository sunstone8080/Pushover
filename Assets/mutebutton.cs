using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutebutton : MonoBehaviour
{

    private bool isMuted;




    private void Start()
    {
        isMuted = false;

    }

    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
       

    }








}
