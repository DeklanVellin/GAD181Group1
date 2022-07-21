using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordDateController : MonoBehaviour
{

    public int ButtonID;

    SwordDate_Script dateCheck;

    // Start is called before the first frame update
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
            print("button pressed");
            dateCheck.ButtonActivated(ButtonID);
        }
    }
}
