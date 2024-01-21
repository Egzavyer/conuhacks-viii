using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public TMP_Text finalScoreText;
    public ScoreText scoreText;
    // Start is called before the first frame update
    void Start()
    {

        finalScoreText.text = "Final Score: " + ScoreText.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        ScoreText.score = 0f;
        SceneManager.LoadScene("main");
    }
}
