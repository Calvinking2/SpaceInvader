using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PointManager : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;
    public bool isWin = false;
    void Start()
    {
        scoreText.text = "Score: " + score;
        if(SceneManager.GetActiveScene().name == "You Win") {
            UpdateScore(score);
            HighScoreUpdate();
            finalScoreText.text = score.ToString();
            highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
        }
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void HighScoreUpdate()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            if(score > PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("highScore", score);
        }
        
        finalScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }
}
