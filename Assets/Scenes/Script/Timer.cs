using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image timebar;
    public float maxtime;
    public float timeleft;
    public float timelv;
    public float starttime;
    public int lv = 1;

    // Start is called before the first frame update
    void Start()
    {
        timebar = GetComponent<Image>();
        timeleft = starttime;

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
                    timeleft = maxtime;
                    lv++;
                    if (lv % 5 == 0 && maxtime > 0.6)
                    {
                        maxtime -= timelv;
                    }
                }




                if (hit.transform.name == "ButtonRight")
                {
                    timeleft = maxtime;
                    lv++;
                    if (lv % 5 == 0 && maxtime > 0.6)
                    {
                        maxtime -= timelv;
                    }
                }


            }


        }
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timebar.fillAmount = timeleft / maxtime;
        }

    }
}
