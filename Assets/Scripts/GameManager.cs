using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public 
    void Start()
    {

    }

    void Update()
    {

    }

    public static void GameOver()
    {
        Debug.Log("Game Over");
        //SceneManager.LoadScene("GameOver");
    }
}
