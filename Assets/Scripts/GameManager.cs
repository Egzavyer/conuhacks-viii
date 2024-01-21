using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static int cash = 0;
    public static int wave = 1;

    void Start()
    {

    }

    void Update()
    {

    }

    public static void GameOver()
    {
        //Debug.Log("Game Over");
        //score = ScoreText.score;
        SceneManager.LoadScene("GameOver");
    }
}
