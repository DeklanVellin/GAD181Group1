using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int playerLives;
    public int totalWins;

    void Start()
    {
        //Checks if we've started storing wins yet, shouldn't try to pull if it doesn't exist yet
        totalWins = PlayerPrefs.GetInt("WinTotal");
        playerLives = PlayerPrefs.GetInt("CurrentLives");

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
        if (totalWins >= 5 && playerLives > 0)
		{
			SceneManager.LoadScene(13);
		}
		else if(playerLives <= 0)
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
			print("Game won, total lives:" + playerLives);
            PlayerPrefs.SetInt("WinTotal", totalWins);
            //This loads the WIN scene
            SceneManager.LoadScene(6);

        }
        else
        {
            playerLives--;
			print("Game lost, total lives:" + playerLives);
            PlayerPrefs.SetInt("CurrentLives", playerLives);
            //This loads the LOSE scene
            SceneManager.LoadScene(7);
        }
    }
}
