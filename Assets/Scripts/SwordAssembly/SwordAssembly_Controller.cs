using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAssembly_Controller : MonoBehaviour
{
    public bool gameActive = true;
    int sequenceProgress = 0;

    float gameTimer = 4;

    SceneController gameComplete;
    public SwordAssembly_ButtonScript[] swordPieces;
    public GameObject[] swordParts;
    public Transform[] positions;

    // Start is called before the first frame update
    void Start()
    {
        gameComplete = FindObjectOfType<SceneController>();

        // Scrmable button locations
        List<Vector3> buttonPositions = new List<Vector3> {swordPieces[0].transform.position, 
                                                           swordPieces[1].transform.position, 
                                                           swordPieces[2].transform.position, 
                                                           swordPieces[3].transform.position
                                                          };

        for(int i = 0; i < 4; i++)
        {
            int randomNumber = Random.Range(0, buttonPositions.Count);
            swordPieces[i].transform.position = buttonPositions[randomNumber];
            buttonPositions.Remove(buttonPositions[randomNumber]);
        }

        // Randomly place the objects in the gamespace
        for (int i = 0; i < swordParts.Length; i++)
        {
            float randX = Random.Range(-205, 166);
            float randY = Random.Range(-65, 121);
            swordParts[i].transform.position = new Vector3(transform.position.x + randX,
                                                           transform.position.y + randY,
                                                           transform.position.z
                                                          );
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Count down 4 seconds for player to complete the game
        gameTimer -= Time.deltaTime;

        if(sequenceProgress == 4 && gameActive)
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
                MovePiece();
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

    void MovePiece()
    {
        swordParts[sequenceProgress].transform.position = positions[sequenceProgress].position;
    }
}
