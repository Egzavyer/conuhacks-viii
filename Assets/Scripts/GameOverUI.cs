using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;
    public ScoreText scoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (ScoreText.score > PlayerPrefs.GetFloat("highscore", 0))
        {
            PlayerPrefs.SetFloat("highscore", ScoreText.score);
        }
        finalScoreText.text = "Final Score: " + ScoreText.score.ToString();
        highScoreText.text = "High Score: " + PlayerPrefs.GetFloat("highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        ScoreText.score = 0f;
        GameManager.wave = 1;
        SceneManager.LoadScene("main");
    }
}
