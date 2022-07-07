using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboo_GameController_SCR : MonoBehaviour
{
    public bool failedGame = false;
    private int success = 0;
    public bool inZone;

    private void PointOver()
    {
        if (inZone == true)
        {
            success++;
        }
        else if (inZone == false)
        {
            failedGame = true;
        }
        
    }

    

    private void CheckWinLose()
    {

        if (failedGame == false && success == 3)
        {
            //Play win animation/transition scene
            print("hooray");
        }
        else if (failedGame == true)
        {
            //Play lose animation/transition scene
            print("oh no");
        }
    }
}
