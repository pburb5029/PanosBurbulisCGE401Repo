using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text winLossText;
    public GameObject startTextPanel;

    private bool gameOver = false;
    private bool gameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            startTextPanel.SetActive(false);
            Time.timeScale = 1f;
            gameStarted = true;
        }

        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void WinGame()
    {
        winLossText.text = "You Win! Press R to Restart";
        EndGame();
    }

    public void LoseGame()
    {
        winLossText.gameObject.SetActive(true);
        EndGame();
    }

    private void EndGame()
    {
        winLossText.text = "You Lose! Press R to Restart";
        gameOver = true;
        Time.timeScale = 0f;
        startTextPanel.SetActive(false);
    }
}
