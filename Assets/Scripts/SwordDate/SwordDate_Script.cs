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

	SceneController gameComplete;
	
	void Start()
	{
		gameComplete = GameObject.FindObjectOfType<SceneController>();
		correctDateButton = Random.Range (1,5);
	}
	
	private void Update()
	{
		dateTimer -= Time.deltaTime;
		
		if(dateTimer <= 0)
		{
			gameComplete.WinScreen(false);
		}
	}
	
	public void ButtonActivated(int buttonID)
	{
		if(buttonID == correctDateButton && gameActive)
		{
			print("Date successful!");
			gameActive = false;
			gameComplete.WinScreen(true);
		}
		else
		{
			print("She hates your guys");
			gameActive = false;
			gameComplete.WinScreen(false);
		}
	}
}
