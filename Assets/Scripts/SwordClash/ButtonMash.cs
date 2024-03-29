using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMash : MonoBehaviour
{

    public float enemyTimer = 0;
    public float enemyPeriod = 0.2f;

    bool winCondition = true;
    public bool canPlay = true;

    public int playerCount = 0;
    public int enemyCount = 0;

    public int currentScore = 0;

    public GameObject indicator;

    float speed = 0.5f;

    public float secondsLeft;
    bool isCounting = true;

    void Start()
    {
        secondsLeft = 4;
    }
    // Update is called once per frame
    void Update()
    {
        if(canPlay == true)
        {
            //press space to increase playercount
            if (Input.GetButtonDown("Fire1"))
            {
                playerCount++;
            }


            //when the enemy timer is below or equal to zero, increase enemy count and reset the timer to the enemy period
            if (enemyTimer <= 0)
            {
                enemyCount++;
                enemyTimer = enemyPeriod;
                //Random.Range(enemyPeriod - 0.1f, enemyPeriod + 0.1f);
            }

            //the enemy timer ticks down by deltatime, so by roughly one 60th of a second, or the amount of time since the last frame
            enemyTimer -= (Time.deltaTime);


            //enemy moves to the left, player moves to the right, position of object is the difference between the player score and enemy score
            indicator.transform.position = new Vector3((playerCount - enemyCount) * speed, -1.4f, 0);

            //the score is determined by the difference between the player and the enemies
            currentScore = playerCount - enemyCount;

            if (currentScore == 9)
            {
                //Setting the win condition to TRUE
                //checking if the win condition is TRUE from before
                if (winCondition == true) //&& secondsLeft < 5
                {

                    canPlay = false;
                    GameObject.FindObjectOfType<SceneController>().WinScreen(true);


                }
                
            }
            if (isCounting == true)
            {
                if (secondsLeft > 0)
                {
                    secondsLeft -= Time.deltaTime;
                    GameObject.FindGameObjectWithTag("TimerSword").transform.position += Vector3.down * Time.deltaTime;
                }

                if (secondsLeft <= 0)
                {
                    winCondition = false;

                    CheckWinLoss();

                }
            }
        }
    }
    public void CheckWinLoss()
    {
        
        canPlay = false;
        GameObject.FindObjectOfType<SceneController>().WinScreen(false);

    }   
}
