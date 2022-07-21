using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSwordClean : MonoBehaviour
{
    public float dateTimer = 4f;
    public bool winCondition;
    public SceneController gameComplete;
    public int clean = 0;

    void Update()
    {
        dateTimer -= Time.deltaTime;

        if (dateTimer <= 0)
        {
            gameComplete.WinScreen(false);
        }

        if (clean == 3)
        {
            winCondition = true;
            WinLoss();
        }

    }

    void WinLoss()
    {
        //if (winCondition == true && dateTimer < 5)
        //print("You've cleaned the sword!");

        GameObject.FindObjectOfType<SceneController>().WinScreen(true);
        

    }
}
