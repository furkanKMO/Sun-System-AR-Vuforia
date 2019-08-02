using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g4 : MonoBehaviour
{
    private string sec = "";
    public Text a;

    private void OnMouseDown()
    {
        sec = "MARS";
        a.text = sec;
        Debug.Log(sec);


    }
}
