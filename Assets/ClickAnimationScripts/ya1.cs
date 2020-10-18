using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class ya1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            
            GetComponent<Renderer>().material.color = new Color(0.5f,0.5f,0.5f, 1f );
        }
        
        if (Input.GetKeyUp("z"))
        {
            GetComponent<Renderer>().material.color = new Color(0.8962264f,0.8913648f,0.8573336f,1f );
        }
    }
}
