using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerButton : MonoBehaviour
{
	public Button myButton;
	
	void OnTriggerStay(Collider colliderData)
	{
		print("collision");
		if(Input.GetButton("Fire1"))
		{
			myButton.onClick.Invoke();
		}
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
