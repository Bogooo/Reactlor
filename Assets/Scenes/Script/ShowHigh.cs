using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowHigh : MonoBehaviour
{
    public TextMeshProUGUI high;

    // Start is called before the first frame update
    void Start()
    {
        int b = PlayerPrefs.GetInt("high");
        high.text = b.ToString();

    }

 
}
