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
    public GameObject shopPanel;
    public GameObject scoreText;
    public GameObject cashText;
    public GameObject waveText;
    public static bool shopOpen = false;

    void Start()
    {
        cash = PlayerPrefs.GetInt("cash", 0);
        GameObject.Find("WaveText").GetComponent<TMP_Text>().text = "Wave " + wave.ToString();
        Invoke(nameof(HideWaveText), 2.0f);
        shopPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (!shopOpen)
            {
                shopOpen = true;
                scoreText.SetActive(false);
                cashText.SetActive(false);
                waveText.SetActive(false);
                shopPanel.SetActive(true);
                PauseGame();
            }
            else if (shopOpen)
            {
                shopOpen = false;
                scoreText.SetActive(true);
                cashText.SetActive(true);
                waveText.SetActive(true);
                shopPanel.SetActive(false);
                ResumeGame();
            }

        }
    }

    public void UpdateCash()
    {
        cash += (int)(10 * (wave / 2.0f));
    }

    public static void GameOver()
    {
      
        PlayerPrefs.SetInt("cash", cash);
        SceneManager.LoadScene("GameOver");
    }
    public static void NextWave()
    {
        PlayerPrefs.SetInt("cash", cash);
        wave += 1;
        SceneManager.LoadScene("main");
    }

    void HideWaveText()
    {
        if (GameObject.Find("WaveText") != null)
        {
            GameObject.Find("WaveText").GetComponent<TMP_Text>().text = "";
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
