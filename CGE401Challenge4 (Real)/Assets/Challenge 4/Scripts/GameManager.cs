using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text waveText;
    public Text winLossText;
    public SpawnManagerX spawnManager;
    public int maxWave = 10;

    private bool gameActive = false;
    private bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        winLossText.text = "Complete round 10 → Win\n0 goals in round → Lose\n\nPress SPACE To Start";
        waveText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameActive && !gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartGame();
            }
            return;
        }

        if (gameActive)
        {
            waveText.text = "Wave: " + (spawnManager.waveCount - 1);

            if (spawnManager.enemyCount > 0)
            {
                foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
                {
                    if (enemy.transform.position.z < -10f)
                    {
                        GameOver(false);
                    }
                }
            }

            // Check win condition
            if (spawnManager.waveCount > (maxWave + 1))
            {
                GameOver(true);
            }
        }

        // Restart
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }

    void StartGame()
    {
        Time.timeScale = 1f;
        gameActive = true;
        spawnManager.gameActive = true;
        winLossText.text = "";
    }

    public void GameOver(bool win)
    {
        gameOver = true;
        gameActive = false;
        Time.timeScale = 0f;
        winLossText.text = win ? "You Win! Press R to Restart!" : "You Lose! Press R to Restart!";
        spawnManager.gameActive = false;
    }
}
