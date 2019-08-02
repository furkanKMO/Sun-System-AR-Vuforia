using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class g1 : MonoBehaviour
{
    private string sec = "";
    public Text a;

    private void OnMouseDown()
    {
        sec = "MERKÜR";
        a.text = sec;
        Debug.Log(sec);


    }
}
