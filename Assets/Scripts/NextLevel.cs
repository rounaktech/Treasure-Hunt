using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject wonui1;
    public void nextlevel()
    {
        wonui1.SetActive(false);
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
