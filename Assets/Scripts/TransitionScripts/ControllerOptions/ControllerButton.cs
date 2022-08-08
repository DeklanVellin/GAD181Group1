using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerButton : MonoBehaviour
{
	public Button myButton;
	
	//Allows the button to be clicked when 'Fire1' is over it, also detects when the cursor and colliders collide.
	void OnTriggerStay(Collider colliderData)
	{
		print("collision");
		if(Input.GetButton("Fire1"))
		{
			myButton.onClick.Invoke();
		}
	}
}
