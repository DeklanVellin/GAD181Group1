using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwordDate_Script : MonoBehaviour
{
    public bool correctButtonPress;
	public float dateTimer = 4f;
	public bool gameActive = true;
	public int correctDateButton;
	public SwordDateController[] myButtons;
	//string[] myResponses = new String[]{ "Oh, she's my sister!", "I'm having an affair.", "Uhhh... no one?", "She's my work wife."};
	

	SceneController gameComplete;
	
	void Start()
	{
		gameComplete = GameObject.FindObjectOfType<SceneController>();
		//Random.Range choosing a random button from the 4 to be the correct one
		correctDateButton = 1;
		
		//List<Vector3> buttonPositions = new List<Vector3> {new Vector3(-201, -12, 0), new Vector3(10, -12, 0), new Vector3(-201, -164, 0), new Vector3(10, -164, 0)};
		List<Vector3> buttonPositions = new List<Vector3> {myButtons[0].transform.position, myButtons[1].transform.position, myButtons[2].transform.position, myButtons[3].transform.position};
		
		for(int i = 0; i < 4; i++)
		{
			int randomNumber = Random.Range(0,buttonPositions.Count);
			myButtons[i].transform.position = buttonPositions[randomNumber];
			buttonPositions.Remove(buttonPositions[randomNumber]);
		}
	}
	
	private void Update()
	{
		//timer nonsense! First line is setting up the timer itself while the if statement is 'if the timer reachers 0, load lose screen'
		dateTimer -= Time.deltaTime;
		
		if(dateTimer <= 0)
		{
			gameComplete.WinScreen(false);
		}
	}

	/*public void SetUpButton(string myNewContent)
	{
      GameObject.Find(correctDateButton).GetComponentInChildren<Text>().text = "Button Text";
	}
	*/
	
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
