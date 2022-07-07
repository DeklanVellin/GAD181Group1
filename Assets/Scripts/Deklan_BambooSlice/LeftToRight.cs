using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftToRight : MonoBehaviour
{
    private int speed = 2;
    public int activationSequence;
    public bool failedGame;

    public Bamboo_GameController_SCR MyManager;

    void Start()
    {
    }

    private Vector3 dir = Vector3.left;

    //Your Update function
    void Update()
    {

        if (activationSequence == 0)
        {
            transform.Translate(dir * speed * Time.deltaTime);

            if (transform.position.x <= -8)
            {
                dir = Vector3.right;
            }
            else if (transform.position.x >= 8)
            {
                dir = Vector3.left;
            }

            if (Input.GetKeyDown("space"))
            {

                positionCheck();

            }
        }
        if (Input.GetKeyDown("space"))
        {
            activationSequence--;
        }


    }

    public void positionCheck()
    {
       
        
            
        if (transform.position.x <= 2 && transform.position.x >= -2)
        {
            print("You win!");
            //MyManager.ReportWinLose(true);
        }
        else
        {
            print("Unlucky");
            //MyManager.ReportWinLose(false);
        }
        
    }
    //public void WinCounter(bool oneGameResult)
}
