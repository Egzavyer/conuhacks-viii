using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreText : MonoBehaviour
{
    public TMP_Text scoreText;
    public static float score = 0f;
    void Start()
    {
        InvokeRepeating(nameof(IncreaseScoreEverySecond), 0, 0.001f);
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void IncreaseScoreEverySecond()
    {
        score += 1.0f;
    }
}
