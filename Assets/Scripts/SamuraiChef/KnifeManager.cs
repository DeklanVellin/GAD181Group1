using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
	SceneController gameComplete;
	
    private float speed = 15f;
	public float cookingTimer = 4f;

	//- Successful cuts, needs 3/4 to win
    public int success;
	private Vector3 dir = Vector3.left;
	//- Failsafe to make sure game stops when it's supposed to and transitions, true by default. Turned off at end of the game.
    public bool canPlay = true;

    void Update()
    {
		if (Input.GetButtonDown("Fire1"))
		{
			//print("ballin");
		}

        if (canPlay == true)
        {
            //transform.Translate(dir * speed * Time.deltaTime);

            //dir = Vector3.right;
			 transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
		
		//Timer nonsense! Harvested from Sword Date.
		cookingTimer -= Time.deltaTime;
		
		if(cookingTimer <= 0)
		{
			//- 3 Needed to win. Checks success from the other script.
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
    }
}
