using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g5 : MonoBehaviour
{
    private string sec = "";
    public Text a;

    private void OnMouseDown()
    {
        sec = "JUPİTER";
        a.text = sec;
        Debug.Log(sec);


    }
}
