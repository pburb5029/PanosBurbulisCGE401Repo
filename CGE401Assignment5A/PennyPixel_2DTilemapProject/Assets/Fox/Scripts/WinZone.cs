/*
* Panos Burbulis
* WinZone.cs
* Assignment 5A
* Detects if player has triggered win zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.CheckWinCondition();
        }
    }
}

