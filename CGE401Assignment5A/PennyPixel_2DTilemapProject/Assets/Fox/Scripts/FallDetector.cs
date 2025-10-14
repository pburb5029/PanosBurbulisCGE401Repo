/*
* Panos Burbulis
* FallDetector.cs
* Assignment 5A
* Detects if player is below fall threshold
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetector : MonoBehaviour
{
    public float fallYThreshold = -4;

    void Update()
    {
        if (transform.position.y < fallYThreshold)
        {
            ScoreManager.Instance.GameOver();
        }
    }
}
