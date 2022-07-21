using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboo_GameController_SCR : MonoBehaviour
{
    public bool failedGame = false;
    private int success = 0;
    public bool inZone;
    private int checking = 0;
    public float secondsLeft;
    bool isCounting = true;


    void Start()
    {
        secondsLeft = 4;
    }

    void Update()
    {
        if (isCounting == true)
        {
            if (secondsLeft > 0)
            {
                secondsLeft -= Time.deltaTime;
            }

            if (secondsLeft <= 0)
            {
                failedGame = true;

                CheckWinLose();
            }
        }
    }

    public void PointOver()
    {
        if (inZone == true)
        {
            success++;
            checking++;
        }
        else if (inZone == false)
        {
            failedGame = true;
            checking++;
        }

        if (checking == 3)
        {
            CheckWinLose();
        }
    }

    

    private void CheckWinLose()
    {

        if (failedGame == false && success == 3)
        {
            //Play win animation/transition scene
            
            GameObject.FindObjectOfType<SceneController>().WinScreen(true);

        }
        else if (failedGame == true)
        {
            //Play lose animation/transition scene
            
            GameObject.FindObjectOfType<SceneController>().WinScreen(false);
        }
    }
}

