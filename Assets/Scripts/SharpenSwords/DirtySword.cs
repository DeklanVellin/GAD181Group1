using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtySword : MonoBehaviour
{
    void Start()
    {
        
    }


    //collison thing on sword
    void OnCollisionExit(Collision collisionData)
    {
        if (collisionData.gameObject.name == "Hand")
        {
            print("Don't touch me " + collisionData.gameObject.name);
            
            Destroy(this.gameObject);
            GameObject.FindObjectOfType<IsSwordClean>().clean++;
        }

    }

}
   
//counter how many times it swipes

   /* if (Collision == gameObject)
       {
       
        } */


