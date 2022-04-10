using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main  instance;

    public WEB web;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        web.GetComponent<WEB>();
    }

}
