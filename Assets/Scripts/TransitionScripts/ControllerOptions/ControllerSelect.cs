using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSelect : MonoBehaviour
{
	public static int controllerOn;
	
	void Start()
	{
		//Checks if we're storing PlayerPref on if the controller mode is on or not. PlayerPrefs means this will endure across all microgames and won't be deleted after leaving the menu.
		controllerOn = PlayerPrefs.GetInt("controllerOn");
	}
	//This script will be on a button in the menu allowing players to click it and choose either Keyboard/mouse or controller to play with.
    public void OnClick()
	{
		if(controllerOn == 0)
		{
		//Adds 1 to controllerOn setting it to 'On'.
		controllerOn++;
		//Sets controllerOn to 1 which means controller settings are enabled.
		PlayerPrefs.SetInt("controllerOn", 1);
		print("Controller mode has been turned on");
		}

		else
		{
		//Takes 1 away from controllerOn to set it to 'Off'.
		controllerOn--;
		//Sets controllerOn to 0 which means keyboard/mouse are enabled.
		PlayerPrefs.SetInt("controllerOn", 0);
		print("Keyboard and mouse mouse has been turned on");
		}
	}
}
