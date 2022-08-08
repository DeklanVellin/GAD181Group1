using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordDateController : MonoBehaviour
{

    public int ButtonID;

    SwordDate_Script dateCheck;

    //This is communicating with the script on the buttons so the same script isn't running on 4 buttons at the same time
    void Start()
    {
        dateCheck = FindObjectOfType<SwordDate_Script>();
    }

    public void ButtonPressed()
    {
        //this line is testing if the code is detecting the correct button being pressed
        print("Button with ID" + ButtonID);
        if(dateCheck.gameActive)
        {
            //turns the button red when pressed! Just a visual flair
            this.GetComponent<Image>().color = Color.red;
			if( ButtonID == 1)
			{
				this.GetComponent<Image>().color = Color.green;
			}
            print("button pressed");
            dateCheck.ButtonActivated(ButtonID);
        }
    }
	
		
	
	
}
