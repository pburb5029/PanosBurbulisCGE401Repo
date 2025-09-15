/*
* Panos Burbulis
* DestroyOutOfBounds.cs
* Prototype 2
* Destroys any object upon out of bounds
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < bottomBound)
        {
            // Debug.Log("Game Over!");

            // Grab health system cscript and call TakeDamage()
            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }
    }
}
