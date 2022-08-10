using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiChef_ObjectManager : MonoBehaviour
{
    private float speed = 2.5f;

	//- Successful cuts, needs 3/4 to win
    public int success;
	private Vector3 dir = Vector3.left;
	//- Failsafe to make sure game stops when it's supposed to and transitions, true by default. Turned off at end of the game.
    public bool canPlay = true;

    void Update()
    {
        if (canPlay == true)
        {
            transform.Translate(dir * speed * Time.deltaTime);

            dir = Vector3.right;
			//- When object reaches right side of screen, stop.
            if (transform.position.x >= 10)
            {
				//- Failsafe turned on, game ends. Not set to a timer rather when the orb reaches the desired place.
                canPlay = false;
				//- Check the status of the 'success' variable.
                CheckWinLose();
            }
        }
    }

    void CheckWinLose()
    {
		//- 3 Needed to win.
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

    /* //if the main object is inside of the cutting zone
    void OnTriggerStay(Collider otherCollider)
    {	
        
        //and the player presses space or a
        if (Input.GetButtonDown("Fire1"))
        {
            print("Cube interacted with successfully");
			//add a point to winning
            success++;
            //change the colour of the object that the cutting zone is on
            otherCollider.gameObject.GetComponent<Renderer>().material.color = Color.red;
            //delete the cutting zone collider
            Destroy(otherCollider);
        }
    }*/
}
