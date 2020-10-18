using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class tz : MonoBehaviour
{
    Animation anim;
    Transform tronsform;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>() ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("]"))
        {
            anim.Play();
        }
    }
}
