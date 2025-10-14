/*
* Panos Burbulis
* ScoreManager.cs
* Assignment 5A
* Manages player score. Updates score and determines game over result
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public Text scoreText;
    public int winScore = 10;
    private int score = 0;
    private bool gameOver = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore(int amount)
    {
        if (!gameOver)
        {
            score += amount;
            scoreText.text = "Score: " + score;
        }
    }

    public void GameOver()
    {
        if (gameOver) return;

        gameOver = true;
        scoreText.text = "You Lose!\n Press R to try again!";
    }

    public void CheckWinCondition()
    {
        if (gameOver) return;

        gameOver = true;

        if (score >= winScore)
        {
            scoreText.text = "You win!\nPress R to try again!";
        }
        else
        {
            scoreText.text = "You need more gems!";
        }
    }
}