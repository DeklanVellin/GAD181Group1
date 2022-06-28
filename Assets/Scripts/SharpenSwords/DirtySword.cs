using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtySword : MonoBehaviour
{
    public int sharpCounter = 0;
    //collison thing on sword
    void OnCollisionExit(Collision collisionData)
    {
        if (collisionData.gameObject.name == "Hand")
        {
            print("Don't touch me " + collisionData.gameObject.name);
            sharpCounter++;
        }
      
    }

    //counter how many times it swipes

   /* if (Collision == gameObject)
       {
       
        } */


}
