using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secim : MonoBehaviour
{
    private string sec = "";
    public Text a;
    
    private void OnMouseDown()
    {
        sec = "GÜNEŞ";
        a.text = sec;
        Debug.Log(sec);
        

    }
}
