using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class ctrl1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            
            GetComponent<Renderer>().material.color = new Color(0.5f,0.5f,0.5f, 1f );
        }
        
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            GetComponent<Renderer>().material.color = new Color(0.65f,0.6153333f,0.546f,1f );
        }
    }
}
