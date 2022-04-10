using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORtext : MonoBehaviour
{
    public Text scor;
    public int lv;
    public int random;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && Time.timeScale == 1)
            {
                if (hit.transform.name == "ButtonLeft" || hit.transform.name == "ButtonRight")
                {
                    lv++;
                    random = Random.Range(0, 10);
                    scor.text = (lv * 10 + random).ToString();
                }

            }
        }
    }

}

