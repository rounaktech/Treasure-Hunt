using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneReload : MonoBehaviour
{
    public GameObject wonui;
    // Start is called before the first frame update
    void Start()
    {
        wonui.SetActive(false);
        ScoreSystem.currentscore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
