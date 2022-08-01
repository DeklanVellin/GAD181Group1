using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int remainingLives;
    public int totalWins;

    void Start()
    {
        //Checks if we've started storing wins yet, shouldn't try to pull if it doesn't exist yet

        totalWins = PlayerPrefs.GetInt("WinTotal");
        remainingLives = PlayerPrefs.GetInt("CurrentLives");

        /*
        if (PlayerPrefs.HasKey("WinTotal"))
        {
            PlayerPrefs.SetInt("WinTotal", currentWins);   
        } 
        else
        {
            PlayerPrefs.SetInt("WinTotal", currentWins = 0);
        }
        */

        //For the final win screens to show if you won or lost the game
        if (totalWins >= 7 && remainingLives > 0)
		{
			SceneManager.LoadScene(13);
		}
		else if(remainingLives <= 0)
		{
			SceneManager.LoadScene(14);
		}
    }

    public void WinScreen(bool winCondition)
    {
        //This has a box that can be checked in the actual Unity window itself
        //This could probably just be changed to a bool that tracks the win/lose condition since the buttons are just an example for now
        if (winCondition == true)
        {
            totalWins++;
            PlayerPrefs.SetInt("WinTotal", totalWins);
            //This loads the WIN scene
            SceneManager.LoadScene(6);

        }
        else
        {
            remainingLives--;
            PlayerPrefs.SetInt("CurrentLives", remainingLives);
            //This loads the LOSE scene
            SceneManager.LoadScene(7);
        }
    }
}
