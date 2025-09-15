/*
* Panos Burbulis
* DetectCollisions.cs
* Prototype 2
* Detects if projectile collides with animals. Then destroyes objects
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
