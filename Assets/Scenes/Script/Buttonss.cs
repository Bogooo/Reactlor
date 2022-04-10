using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonss : MonoBehaviour
{
    public Color ButonColor;
    public float r;
    public float g;
    public float b;



    public Renderer ButonRender;

    // Start is called before the first frame update
    void Start()
    {
        ButonRender = gameObject.GetComponent<Renderer>();


        ButonColor = new Color(r, g, b, 1f);
        ButonRender.material.color = ButonColor;



    }

    // Update is called once per frame
    void Update()
    {

    }
}
