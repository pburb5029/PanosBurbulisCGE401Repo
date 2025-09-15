﻿/*
* Panos Burbulis
* SpawnManagerX.cs
* Challenge 2
* Spawns balls continuosly until game over condition true
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    public HealthSystem healthSystem;
    public DisplayScoreX displayScore;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());

        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        displayScore = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScoreX>();

    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        // Add a 3 second delay before first spawning objects
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver && !displayScore.gameOver)
        {
            SpawnRandomBall();

            float randomDelay = Random.Range(3.0f, 5.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
