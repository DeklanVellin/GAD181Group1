using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtCollide : MonoBehaviour
{
	//Code to delete dirt without deleting cursor, buggy and not working will work on later.
	
	
    //Allows the button to be clicked when 'Fire1' is over it, also detects when the cursor and colliders collide.
	/*void OnTriggerStay(Collider colliderData)
	{	
		if (collisionData.gameObject.name == "CursorSphere")
        {
            print("Don't touch me " + collisionData.gameObject.name);
            
            Destroy(this.gameObject);
            GameObject.FindObjectOfType<IsSwordClean>().clean++;
        }
	}
	
	 void OnCollisionEnter(Collision collision){
          Destroy(collision.collider.gameObject);
          Destroy(gameObject);
          }*/
}
