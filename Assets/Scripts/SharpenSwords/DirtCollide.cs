using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtCollide : MonoBehaviour
{	
	 void OnTriggerEnter(Collider otherObject)
     {
		 //The dirt has a tag "Dirt" so this code is singalling out those GameObjects and deleting them if they collide with the CursorSphere.
         if(otherObject.tag == "Dirt")
         {
             Destroy(otherObject.gameObject);
			 //This is the same bit of code as with the "Hand" object, adds +1 to the Clean counter for the Win Condition!
			 GameObject.FindObjectOfType<IsSwordClean>().clean++;
			 print("Dirt destroyed");
         
         }
	 }
}
