using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordAssembly_ButtonScript : MonoBehaviour
{
    public int ButtonID;
    SwordAssembly_Controller SequenceCheck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Pressed()
    {
        this.GetComponent<Image>().color = Color.red;
        print("You pressed a button");
        SequenceCheck = FindObjectOfType<SwordAssembly_Controller>();
        SequenceCheck.ButtonActivated(ButtonID);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
