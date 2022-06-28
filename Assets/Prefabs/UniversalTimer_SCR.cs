using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalTimer_SCR : MonoBehaviour
{
    public int secondsLeft;
    public bool takingAway = false;


    void Start()
    {
        secondsLeft = 20;
        //secondsLeft = PlayerPrefs.GetInt("Universal Timer");

    }


    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(timerTake());
        }

        if (secondsLeft == 0)
        {
            print ("Time's Up!");
        }

    }

    IEnumerator timerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        takingAway = false;
    }
}