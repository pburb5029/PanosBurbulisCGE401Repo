/*
* Panos Burbulis
* PlayerEnterTrigger.cs
* Prototype 1
* Makes player gain score on entering trigger zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PlayeEnterTrigger : MonoBehaviour
{
    //set this reference in the inspector
    //public Text textbox;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            //textbox.text = "You Win!";
            ScoreManager.score++;
        }
    }
}
