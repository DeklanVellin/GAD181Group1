using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAssembly_Controller : MonoBehaviour
{
    bool gameActive = true;
    int sequenceProgress = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sequenceProgress == 5 && gameActive)
        {
            print("YOU WIN!!!");
            gameActive = false;
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
                print("You Lose :(");
                gameActive = false;
            }
        }
    }
}
