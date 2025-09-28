/*
* Panos Burbulis
* TriggerZoneAddScore.cs
* Prototype 3
* Adds 1 score when player collides with obstacle trigger zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
