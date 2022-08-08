using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwordDate_Script : MonoBehaviour
{
    public bool correctButtonPress;
	public float dateTimer = 8f;
	public bool gameActive = true;
	public int correctDateButton;
	public SwordDateController[] myButtons;
	public GameObject[] myColliders;
	

	SceneController gameComplete;
	
	void Start()
	{
		gameComplete = GameObject.FindObjectOfType<SceneController>();
		//Random.Range choosing a random button from the 4 to be the correct one
		correctDateButton = 1;
		
		//Grabbing the position of buttons and colliders from in the scene and using those positions to randomise where the buttons are instead of defining their positions in code. This allows us to move the buttons in scene to where we want and have them still work without us needing to edit code.
		List<Vector3> buttonPositions = new List<Vector3> {myButtons[0].transform.position, myButtons[1].transform.position, myButtons[2].transform.position, myButtons[3].transform.position};
		List<Vector3> colliderPositions = new List<Vector3> {myColliders[0].transform.position, myColliders[1].transform.position, myColliders[2].transform.position, myColliders[3].transform.position};
		
		//This loop will randomise button position and then take it out of the pool of potential buttons to randomly place in the positions defined in the step above.
		for(int i = 0; i < 4; i++)
		{
			int randomNumber = Random.Range(0,buttonPositions.Count);
			myButtons[i].transform.position = buttonPositions[randomNumber];
			myColliders[i].transform.position = colliderPositions[randomNumber];
			buttonPositions.Remove(buttonPositions[randomNumber]);
			colliderPositions.Remove(colliderPositions[randomNumber]);
		}
	}
	
	private void Update()
	{
		//Timer nonsense! First line is setting up the timer itself while the if statement is 'if the timer reachers 0, load lose screen'.
		dateTimer -= Time.deltaTime;
		
		if(dateTimer <= 0)
		{
			gameComplete.WinScreen(false);
		}
	}

	public void ButtonActivated(int buttonID)
	{
		//if the button with the correctDateButton on it is pressed while the game is active then you win, load win screen! Else lose and load lose screen.
		if(buttonID == correctDateButton && gameActive)
		{
			//the prints are just to ensure the game is working
			print("Date successful!");
			gameActive = false;
			gameComplete.WinScreen(true);
		}
		else
		{
			print("She hates your guts");
			gameActive = false;
			gameComplete.WinScreen(false);
		}
	}
}
