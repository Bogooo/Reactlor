using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Showleader : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string s;
    
    

    void Start()
    {
        StartCoroutine(Main.instance.web.GetUsers());
        s = PlayerPrefs.GetString("text");
        Debug.Log(s);
        text.text = s;
    }

  

}
