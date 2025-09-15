/*
* Panos Burbulis
* PlayerControllerX.cs
* Challenge 2
* Controls player dog spawning. 1 second cooldown
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float spawnCooldown = 1.0f;   
    float nextSpawnTime = 0f;     

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time >= nextSpawnTime))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextSpawnTime = Time.time + spawnCooldown;
        }
    }
}
