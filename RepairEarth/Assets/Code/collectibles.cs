﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectibles : MonoBehaviour
{
    public GameObject collectible;
    public Slider pollution;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "character")
        {
            Object.Destroy(collectible);
            pollution.value += 5;
        }
    }
}

