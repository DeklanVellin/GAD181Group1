using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRain_GameManager : MonoBehaviour
{
    float rainTimer = 4;
    SceneController gameComplete;

    void OnEnable()
    {
        SwordRain_EventManager.OnDeath += LoseCondition;
    }

    void Start()
    {
        gameComplete = FindObjectOfType<SceneController>();
    }

    void Update()
    {
        rainTimer -= Time.deltaTime;
        GameObject.FindGameObjectWithTag("TimerSword").transform.position += Vector3.down * Time.deltaTime;

        if(rainTimer <= 0)
        {
            print("You Survived!!!");
            gameComplete.WinScreen(true);
        }
    }

    void LoseCondition()
    {
        gameComplete.WinScreen(false);
    }
}
