using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordAssembly_ButtonScript : MonoBehaviour
{
    public int ButtonID;

    SwordAssembly_Controller sequenceCheck;
    SwordAssembly_Controller gamestateCheck;

    // Start is called before the first frame update
    void Start()
    {
        gamestateCheck = FindObjectOfType<SwordAssembly_Controller>();
    }

    public void Pressed()
    {
        if(gamestateCheck.gameActive)
        {
            this.GetComponent<Image>().color = Color.red;
            print("You pressed a button");
            sequenceCheck = FindObjectOfType<SwordAssembly_Controller>();
            sequenceCheck.ButtonActivated(ButtonID);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
