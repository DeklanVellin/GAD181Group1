using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
    void OnMouseOver()
	{
		//If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over a button.");
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on the button.");
	}
}
