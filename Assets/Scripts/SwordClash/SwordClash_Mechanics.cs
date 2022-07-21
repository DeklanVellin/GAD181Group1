using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwordClash_Mechanics : MonoBehaviour
{
    public int n;

    bool winCondition = true;
    float counting = 0;
    public bool canPlay = true;

    void Update()
    {
        if (canPlay == true)
        {
            if (counting > 1)
            {

                transform.position += new Vector3(20f, 0, 0);
                n--;
                counting = 0;
            }
            counting += Time.deltaTime;



            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.position += new Vector3(-10f, 0, 0);

                n ++;
                if (n >= 10)
                {
                    //Setting the win condition to TRUE
                    //checking if the win condition is TRUE from before
                    if (winCondition == true) //&& secondsLeft < 5
                    {
                        win();
                        canPlay = false;
                    }
                    else
                    {
                        lose();
                        canPlay = false;
                    }
                }
            }
        }
    }

    public void win()
    {
        print("yay woo");
        
    }

    public void lose()
    {
        print("aww shucks");
    }
}