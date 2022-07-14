using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMash : MonoBehaviour
{

    public float enemyTimer = 0;
    public float enemyPeriod = 0.2f;

    public int playerCount = 0;
    public int enemyCount = 0;

    public int currentScore = 0;


    public GameObject indicator;

    float speed = 0.09f;

    // Update is called once per frame
    void Update()
    {
        //press z to increase playercount
        if(Input.GetKeyDown("z"))
        {
            playerCount++;
        }


        //when the enemy timer is below or equal to zero, increase enemy count and reset the timer to the enemy period
        if(enemyTimer <= 0)
        {
            enemyCount++;
            enemyTimer = enemyPeriod;
                //Random.Range(enemyPeriod - 0.1f, enemyPeriod + 0.1f);
        }

        //the enemy timer ticks down by deltatime, so by roughly one 60th of a second, or the amount of time since the last frame
        enemyTimer -= (Time.deltaTime);


        //enemy moves to the left, player moves to the right, position of object is the difference between the player score and enemy score
        indicator.transform.position = new Vector3((playerCount - enemyCount) * speed, 0, 0);

        //the score is determined by the difference between the player and the enemies
        currentScore = playerCount - enemyCount;

        if(currentScore == 50)
        {
            print("You Win");            
        }
        if(currentScore == -25)
        {
            print("You Lose");
        }



    }
}
