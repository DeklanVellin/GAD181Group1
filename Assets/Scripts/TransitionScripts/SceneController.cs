using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public bool winCondition = false;
    
    public void winScreen()
    {
        //This has a box that can be checked in the actual Unity window itself
        //This could probably just be changed to a bool that tracks the win/lose condition since the buttons are just an example for now
        if (winCondition == true)
        {
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
