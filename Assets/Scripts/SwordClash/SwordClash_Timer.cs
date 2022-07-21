using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordClash_Timer : MonoBehaviour
{
    public float secondsLeft;

    bool isCounting = true;

    public SwordClash_Mechanics playing;


    void Start()
    {
        secondsLeft = 4;
        //secondsLeft = PlayerPrefs.GetInt("Universal Timer");
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        playing = g.GetComponent<SwordClash_Mechanics>();

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
                print("Time's Up!");
                isCounting = false;
                playing.canPlay = false;
            }
        }

    }


}