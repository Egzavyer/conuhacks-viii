using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static float score;

    void Start()
    {
    }

    void Update()
    {

    }

    public static void GameOver()
    {
        //Debug.Log("Game Over");
        score = ScoreText.score;
        SceneManager.LoadScene("GameOver");
    }
}
