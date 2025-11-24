using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoal : MonoBehaviour
{
    public GameManager gameManager;
    public SpawnManagerX spawnManager;

    private int enemiesReachedGoal = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Enemy")) return;

        Destroy(other.gameObject); // remove enemy
        enemiesReachedGoal++;

        if (enemiesReachedGoal >= spawnManager.currentWaveSize)
        {
            gameManager.GameOver(false);
        }
    }

    public void ResetCounter()
    {
        enemiesReachedGoal = 0;
    }
}
