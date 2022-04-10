﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectLB : MonoBehaviour
{

    public ParticleSystem E;
    public int emit;
    // Start is called before the first frame update
    void Start()
    {
        E = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "ButtonLeft")
                {
                    E.Emit(emit);
                }

            }
        }
    }
}
