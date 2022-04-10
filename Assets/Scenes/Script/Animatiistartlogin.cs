using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animatiistartlogin : MonoBehaviour
{
    public GameObject panel,panel2;
    public float i;

    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(i>0)i -= Time.deltaTime;
        else
        if(i<0)
        {
            panel.SetActive(false);
            panel2.SetActive(false);
        }
    }
}
