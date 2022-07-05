using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboo_GameController_SCR : MonoBehaviour
{
    public bool failedGame;

    private void checkWinLose()
    {
        if (failedGame == true)
        {
            //Play lose animation/transition scene
            print("oh no");
        }
        else
        {
            //Play win animation/transition scene
            print("hooray");
        }
    }
}
