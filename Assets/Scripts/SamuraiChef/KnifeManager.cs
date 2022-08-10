using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
	SceneController gameComplete;
	
    private float speed = 20f;
	public float cookingTimer = 4f;

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
        }
		
		//Timer nonsense! Harvested from Sword Date.
		cookingTimer -= Time.deltaTime;
		
		if(cookingTimer <= 0)
		{
			gameComplete.WinScreen(false);
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
}
