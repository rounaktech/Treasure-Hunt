using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListSwitch : MonoBehaviour
{
    public GameObject listui;

    public void listsw()
    {
        listui.SetActive(true);
    }
        public void backgm()
        {
            listui.SetActive(false);
        }
        
        
}

