using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    public static int currentscore = 0;
    public GameObject wonui;
    void Start()
    {
        wonui.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (currentscore == 10)
        {
            Time.timeScale = 0;
            wonui.SetActive(true);
            PlayerPrefs.SetInt("levelAt", SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Time.timeScale = 1;
            wonui.SetActive(false);
        }
    }
}
