using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Keep track of time and call wins and losses to scene controller
public class FruitNinja_GameManager : MonoBehaviour
{
    SceneController gameComplete;
    float gameTimer = 4f;

    // Start is called before the first frame update
    void Start()
    {
        gameComplete = FindObjectOfType<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;

        if(gameTimer <= 0)
        {
            gameComplete.WinScreen(false);
        }
    }
}
