using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int cash = 0;
    public static int wave = 1;

    void Start()
    {
        GameObject.Find("WaveText").GetComponent<TMP_Text>().text = "Wave " + wave.ToString();
        Invoke(nameof(HideWaveText), 2.0f);
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
    public static void NextWave()
    {
        wave += 1;
        SceneManager.LoadScene("main");
    }

    void HideWaveText()
    {
        GameObject.Find("WaveText").GetComponent<TMP_Text>().text = "";
    }
}
