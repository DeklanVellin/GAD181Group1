using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordAssembly_ButtonScript : MonoBehaviour
{
    public int ButtonID;

    SwordAssembly_Controller controllerCheck;

    // Start is called before the first frame update
    void Start()
    {
        controllerCheck = FindObjectOfType<SwordAssembly_Controller>();
    }

    public void Pressed()
    {
		print("Button with ID" + ButtonID);
        if(controllerCheck.gameActive)
        {
            this.GetComponent<Image>().color = Color.green;
            print("You pressed a button");
            controllerCheck.ButtonActivated(ButtonID);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButtonDown("Fire1"))
        //{
        //    Pressed();
        //}
    }
}
