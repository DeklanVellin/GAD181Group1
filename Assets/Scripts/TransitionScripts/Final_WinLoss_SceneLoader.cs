using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final_WinLoss_SceneLoader : MonoBehaviour
{
    int wins = 0;
    int lives = 3;

    public void Start()
    {
        wins = PlayerPrefs.GetInt("WinTotal");
        lives = PlayerPrefs.GetInt("CurrentLives");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RepeatGame()
    {

    }

}
