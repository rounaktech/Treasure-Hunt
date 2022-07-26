using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnClickDestroy : MonoBehaviour
{
    public GameObject ps;
    public GameObject objname;

    public void OnMouseDown() {
Instantiate(ps, transform.position, Quaternion.identity);
        ScoreSystem.currentscore += 1;
        Destroy(objname);
    Destroy(gameObject);
        


}




    
}
