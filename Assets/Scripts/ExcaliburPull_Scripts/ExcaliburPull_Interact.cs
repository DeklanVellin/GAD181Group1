using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExcaliburPull_Interact : MonoBehaviour
{
    public int n;

    public bool winCondition = false;

    void Update()
    {
        //This is moving the sword up 1 unit everytime space is pressed. The += means it's moving and setting from current coords than just moving the prefab to 0,1,0
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0, 0.25f, 0);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //n is variable we're using to tract space bar clicks. When it reaches 20, it prints the message to the console
            n += 1;
            if (n == 20)
            {
                //Setting the win condition to TRUE
                winCondition = true;
            }
        }
        //Condition for WIN. Lose condition can't work right now since timer isn't implemented. This script is meant to be on a seperate empty game object but I couldn't figure out how to get variables to change across scripts, this is a temporary fix!
        if (n == 20)
        {
            //checking if the win condition is TRUE from before
            if (winCondition == true)

            {
                //This loads the WIN scene
                SceneManager.LoadScene(5);
            }
            else
            {
                //This loads the LOSE scene. Game currently can't have a loss because the timer isn't implemented, but when we do this will work!
                SceneManager.LoadScene(6);
            }
        }
    }
}