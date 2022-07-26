using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevel : MonoBehaviour
{
    public int x=0;
    public void levelselection()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + x);
    }
}
