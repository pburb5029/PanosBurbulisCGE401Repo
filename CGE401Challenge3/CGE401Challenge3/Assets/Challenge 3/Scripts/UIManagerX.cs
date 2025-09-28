/*
* Panos Burbulis
* UIManagerX.cs
* Challenge 3
* Displays score. Displays win/loss text on gameOver
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerX : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public PlayerControllerX playerX;
    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if (playerX == null)
        {
            playerX = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerX.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if (playerX.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to Try Again!";
        }

        if (score >= 10)
        {
            playerX.gameOver = true;
            won = true;

            scoreText.text = "You Win!\nPress R to Try Again!";
        }

        if (playerX.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
