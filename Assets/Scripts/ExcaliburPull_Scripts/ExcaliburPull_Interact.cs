using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExcaliburPull_Interact : MonoBehaviour
{
    public int n;
   
    
    void Update()
    {
        //This is moving the sword up 1 unit everytime space is pressed. The += means it's moving and setting from current coords than just moving the prefab to 0,1,0
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0, 0.25f, 0);
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //n is variable we're using to tract space bar clicks. When it reaches 20, it prints the message to the console
            n += 1;
            if (n == 20)
            {
                Debug.Log("The sword has been freed!");
            }
        }
    }
}