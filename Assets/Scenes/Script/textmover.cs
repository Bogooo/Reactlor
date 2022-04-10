using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textmover : MonoBehaviour
{

    public float speed;
    public GameObject ttt;


    // Update is called once per frame
    void Update()
    {

        ttt.transform.position += new Vector3((-1)*speed * Time.deltaTime,0,0);


    }
}
