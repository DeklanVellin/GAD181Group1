using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalTimer_SCR : MonoBehaviour
{
    public float secondsLeft;



    void Start()
    {
        secondsLeft = 20;
        //secondsLeft = PlayerPrefs.GetInt("Universal Timer");

    }


    void Update()
    {
        if (secondsLeft > 0)
        {
            secondsLeft-=Time.deltaTime;
        }

        if (secondsLeft == 0)
        {
            print ("Time's Up!");
        }

    }

    
}