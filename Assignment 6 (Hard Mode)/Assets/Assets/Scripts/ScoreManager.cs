/*
* Panos Burbulis
* ScoreManager.cs
* Assignment 5B
* Keeps track of score and ends game upon all crates destroyed
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int totalCrates = 10;
    public int destroyedCrates = 0;
    public Text scoreText;
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
        winText.text = "";
    }

    public void CrateDestroyed()
    {
        destroyedCrates++;
        UpdateScoreText();

        if (destroyedCrates >= totalCrates)
        {
            WinGame();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Crates Destroyed: \n" + destroyedCrates + "/" + totalCrates;
    }

    void WinGame()
    {
        scoreText.text = "";
        winText.text = "You Win! \nPress R to try again!";
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyedCrates >= totalCrates && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
