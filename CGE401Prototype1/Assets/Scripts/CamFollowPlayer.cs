/*
* Panos Burbulis
* CamFollowPlayer.cs
* Prototype 1
* Controls camera to follow player
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
