using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    int currentWins = 0;
    void Start()
    {
        //Checks if we've started storing wins yet, shouldn't try to pull if it doesn't exist yet
        if (PlayerPrefs.HasKey("WinTotal"))
        {
            currentWins = PlayerPrefs.GetInt("WinTotal");   
        } 
        else
        {
            PlayerPrefs.SetInt("WinTotal", 0);
        }
    
    }

    public void WinScreen(bool winCondition)
    {
        //This has a box that can be checked in the actual Unity window itself
        //This could probably just be changed to a bool that tracks the win/lose condition since the buttons are just an example for now
        if (winCondition == true)
        {
            //
            PlayerPrefs.SetInt("WinTotal", currentWins + 1);
            //This loads the WIN scene
            SceneManager.LoadScene(5);

        }
        else
        {
            //This loads the LOSE scene
            SceneManager.LoadScene(6);
        }
    }
}
