/*
* Panos Burbulis
* TriggerZoneX.cs
* Challenge 1
* Adds 1 score upon player entering trigger zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneX : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManagerX.score++;
        }
    }
}