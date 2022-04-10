using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorLeft : MonoBehaviour
{

    public Animator Left;
    public bool down=false;

    // Start is called before the first frame update
    void Start()
    {
        Left = GetComponent<Animator>();        
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
                if(hit.transform.name== "ButtonLeft" && down == false)
                {
                    down = true;
                    Left.SetBool("Press", down);
                }
                else
                {
                    down = false;
                    Left.SetBool("Press", down);
                }
            }
        }


    }
}
