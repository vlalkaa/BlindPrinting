using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class _1 : MonoBehaviour
{
    Animation anim;
    Transform tronsform;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("/"))
        {
            
            GetComponent<Renderer>().material.color = new Color(0.5f,0.5f,0.5f, 1f );
        }
        
        if (Input.GetKeyUp("/"))
        {
            GetComponent<Renderer>().material.color = new Color(0.8962264f,0.8913648f,0.8573336f,1f );
        }
    }
}
