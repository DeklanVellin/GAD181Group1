using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAssembly_Controller : MonoBehaviour
{
    public bool gameActive = true;
    int sequenceProgress = 1;

    float gameTimer = 4;

    SceneController gameComplete;

    // Start is called before the first frame update
    void Start()
    {
        gameComplete = FindObjectOfType<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Count down 4 seconds for player to complete the game
        gameTimer -= Time.deltaTime;

        if(sequenceProgress == 5 && gameActive)
        {
            // The player wins if they complete the sequence within the time
            // Then notify the transition manager the game has been won
            print("YOU WIN!!!");
            gameActive = false;

            gameComplete.WinScreen(true);
        }
        else if(gameTimer <= 0 && gameActive)
        {
            // The player loses if time runs out
            // Notify the transition manager the game has been lost
            print("You Lost :(");
            gameActive = false;

            gameComplete.WinScreen(false);
        }
    }

    public void ButtonActivated(int buttonID)
    {
        if (gameActive)
        {
            if(buttonID == sequenceProgress)
            {
                sequenceProgress++;
            }
            else
            {
                // The player loses if they press an incorrect button
                // Notify the transition manager the game has been lost
                print("You Lose :(");
                gameActive = false;

                gameComplete.WinScreen(false);
            }
        }
    }
}
