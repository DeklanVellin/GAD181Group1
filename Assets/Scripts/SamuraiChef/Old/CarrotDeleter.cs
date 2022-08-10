using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotDeleter : MonoBehaviour
{
   void OnTriggerEnter(Collider otherObject)
     {
		 //The carrot has a tag "Carrot" so this code is singalling out those GameObjects and deleting them if they collide with the SC_KnifeObject.
         if(otherObject.tag == "Carrot")
         {
			 if (Input.GetButtonDown("Fire1"))
			 {
             Destroy(otherObject.gameObject);
			 //This is the same bit of code as with the "Hand" object, adds +1 to the Clean counter for the Win Condition!
			 GameObject.FindObjectOfType<SamuraiChef_ObjectManager>().success++;
			 print("Carrot destroyed");
			 }
         }
	 }
    }

