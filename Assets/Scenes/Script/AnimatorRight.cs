using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorRight : MonoBehaviour
{

    public Animator Right;
    public bool down = false;

    // Start is called before the first frame update
    void Start()
    {
        Right = GetComponent<Animator>();
        
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
                if (hit.transform.name == "ButtonRight" && down == false)
                {
                    down = true;
                    Right.SetBool("Press", down);
                }
                else
                {
                    down = false;
                    Right.SetBool("Press", down);
                }
            }
        }

    }
}
