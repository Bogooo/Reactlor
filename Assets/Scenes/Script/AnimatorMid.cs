using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMid : MonoBehaviour
{
    public Animator Mid;
    public bool down= false;


    // Start is called before the first frame update
    void Start()
    {
        Mid = GetComponent<Animator>();

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
                if (hit.transform.name == "ButtonMid" && down == false)
                {
                    down = true;
                    Mid.SetBool("Press", down);
                }
                else
                {
                    down = false;
                    Mid.SetBool("Press", down);
                }
            }
        }
    }
}
