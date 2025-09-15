/*
* Panos Burbulis
* DisplayScore.cs
* Challenge 2
* Displays current score. Checks for victory condition
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScoreX : MonoBehaviour
{
    public Text textbox;

    public int score = 0;

    public bool gameOver = false;
    public GameObject gameWinText;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 5)
        {
            gameOver = true;
            gameWinText.SetActive(true);

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

}