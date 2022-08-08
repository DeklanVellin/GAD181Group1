using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMouse : MonoBehaviour
{
	private int controllerOn;
	public GameObject objectToTrack;
	
	void Start()
	{
		//Getting whatever current PlayerPrefs value is (1,0).
		controllerOn = PlayerPrefs.GetInt("controllerOn");
	}
	
	//FixedUpdate runs at a fixed rate depending on games framerate instead of once every frame.
    void FixedUpdate()
    {
		//If controllerOn == 0 means it's in keyboard and mouse mode.
		if(controllerOn == 0)
		{
			Vector3 mousePos = Input.mousePosition;
			//print(mousePos.x + "x, " + mousePos.y + "y");
			this.transform.position = (mousePos - new Vector3(Screen.width / 2, Screen.height / 2, 0))*0.007f;
		}
		else
		{
			this.transform.position = new Vector3(objectToTrack.transform.position.x, objectToTrack.transform.position.y, this.transform.position.z);
		}
    }
}
