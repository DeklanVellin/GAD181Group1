using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cursor : MonoBehaviour
{
    public float speed;
	public int controllerOn;
	
	private void Start()
	{
		controllerOn = PlayerPrefs.GetInt("controllerOn");
	}
		
    void Update()
    {
		controllerOn = PlayerPrefs.GetInt("controllerOn");
		this.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0)*speed;
        //int controllerOn = get playerpref int for controller support
		/*if(controllerOn == 1)
		{
			Vector3 positionUpdate = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);

			this.transform.position += positionUpdate*0.02f;

			if(Input.GetButtonUp("Fire1"))
				{
				//something goes here to check what we're directly over, and run it's 'OnClick' if it's a button
				
				//Printing to test if the fire button is working
				print("you do be pressing buttons");
				}
		}*/
	}
}

