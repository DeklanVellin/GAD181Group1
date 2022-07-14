using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwordDate_Script : MonoBehaviour
{
    public bool correctButtonPress;
	public float dateTimer = 4f;
	SceneController gameComplete;
	
	void Start()
	{
		gameComplete = GameObject.FindObjectOfType<SceneController>();
	}
	
	private void Update()
	{
		dateTimer -= Time.deltaTime;
		
		if(dateTimer <= 0)
		{
			gameComplete.WinScreen(false);
		}
	}
	
	public void WinCon()
	{
		if(correctButtonPress == true)
		{
			print("Date successful!");
			gameComplete.WinScreen(true);
		}
		else
		{
			print("She hates your guys");
			gameComplete.WinScreen(false);
		}
	}
}
