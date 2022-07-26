using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool pause = false;
    public GameObject pauseui;
    public void pausegame()
    {
        if(pause)
        {
            Time.timeScale = 1;
            pause = false;
            pauseui.SetActive(false);
        }
        else 
        {
            Time.timeScale = 0;
            pause = true;
            pauseui.SetActive(true);
        }
    }
}
