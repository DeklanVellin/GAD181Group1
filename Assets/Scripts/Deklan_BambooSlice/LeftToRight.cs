using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftToRight : MonoBehaviour
{
    private int speed = 5;
    public int activationSequence;
    public bool failedGame;
    

    public Bamboo_GameController_SCR MyManager;

    void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        //MyManager = g.GetComponent<Bamboo_GameController_SCR>();
    }

    private Vector3 dir = Vector3.left;

    //Your Update function
    void Update()
    {

        if (activationSequence == 0)
        {
            transform.Translate(dir * speed * Time.deltaTime);

            if (transform.position.x <= -10.5)
            {
                dir = Vector3.right;
            }
            else if (transform.position.x >= -5.5)
            {
                dir = Vector3.left;
            }

            if (Input.GetButtonDown("Fire1"))
            {

                positionCheck();
                
                
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            activationSequence--;
        }


    }

    public void positionCheck()
    {
       
        
            
        if (transform.position.x <= -7.5 && transform.position.x >= -8.5)
        {
            //print("You win!");
            
            MyManager.inZone = true;
            MyManager.PointOver();

        }
        else
        {
            //print("Unlucky");
            MyManager.inZone = false;
            MyManager.PointOver();
        }

       
        
    }
    
}
