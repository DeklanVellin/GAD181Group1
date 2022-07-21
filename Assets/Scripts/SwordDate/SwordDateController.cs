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
        if(dateCheck.gameActive)
        {
            this.GetComponent<Image>().color = Color.red;
            print("button pressed");
            dateCheck.ButtonActivated(ButtonID);
        }
    }
}
