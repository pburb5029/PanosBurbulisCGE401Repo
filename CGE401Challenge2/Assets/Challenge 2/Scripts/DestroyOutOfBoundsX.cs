﻿/*
* Panos Burbulis
* DestroyOutOfBoundsX.cs
* Challenge 2
* Destroys all objects upon out of bounds
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -25;
    private float bottomLimit = -5;

    private HealthSystem healthSystemScript;

    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    
    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }

    }
}
