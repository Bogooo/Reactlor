using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Showcurent : MonoBehaviour
{
    public TextMeshProUGUI scor;
    // Start is called before the first frame update
    void Start()
    {
        int a = PlayerPrefs.GetInt("curent");
        scor.text = a.ToString();
    }

    
}
