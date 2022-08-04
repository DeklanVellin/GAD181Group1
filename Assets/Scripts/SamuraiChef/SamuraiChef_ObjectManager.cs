using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiChef_ObjectManager : MonoBehaviour
{
    private float speed = 2.5f;

    private int success;

   

private Vector3 dir = Vector3.left;

    public bool canPlay = true;

    //public bool isColliding = false;




    
    void Update()
    {
        if (canPlay == true)
        {
            transform.Translate(dir * speed * Time.deltaTime);

            dir = Vector3.right;

            

            


            /*if (Input.GetKeyDown("space") && transform.position.x <= 2 && transform.position.x >= 1 || 
                Input.GetKeyDown("space") && transform.position.x <= 4 && transform.position.x >= 3 ||
                Input.GetKeyDown("space") && transform.position.x <= 6 && transform.position.x >= 5 ||
                Input.GetKeyDown("space") && transform.position.x <= 8 && transform.position.x >= 7)
            {
                print("YOU WIN");
                success++;
                //add thing to only work once
            }
            */

            //checking whether the cutting object is at position 10 or greater, if they are, end the game and check winning state   
            if (transform.position.x >= 10)
            {
                canPlay = false;
                CheckWinLose();
            }
        }
    }

    void CheckWinLose()
    {
        if (success >=3)
        {
            print("YOU WIN");
            //Run Win Transition
            GameObject.FindObjectOfType<SceneController>().WinScreen(true);
        }
        else
        {
            print("YOU LOSE");
            //Run Lose Transition
            GameObject.FindObjectOfType<SceneController>().WinScreen(false);
        }
    }

    
    //if the main object is inside of the cutting zone
    void OnTriggerStay(Collider otherCollider)
    {
        
        //and the player presses space or a
        if (Input.GetButtonDown("Fire1"))
        {
            //add a point to winning
            success++;
            //change the colour of the object that the cutting zone is on
            otherCollider.gameObject.GetComponent<Renderer>().material.color = Color.red;
            //delete the cutting zone collider
            Destroy(otherCollider);
            

        }
    }


    void OnTriggerExit(Collider otherCollider)
    {
        
    }



}
