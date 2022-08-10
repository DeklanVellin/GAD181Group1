using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInteract : MonoBehaviour
{
 //Collission on knife and carrot objects.
    void OnCollisionExit(Collision collisionData)
    {
        if (collisionData.gameObject.name == "KnifeCube")
        {
			//If these objects interact with "KnifeCube"-
            print("Cut interacted with: " + collisionData.gameObject.name);
            
			//-while also having "Fire1" pressed-
			if(Input.GetButton("Fire1"))
			{
				//-Destroy this GameObject!
				print("Cut!");
				Destroy(this.gameObject);
				//Broken but this will add 1 to success tally. Need to get the code for swapping out sprites instead of just destroying the game object.
				GameObject.FindObjectOfType<KnifeManager>().success++;
			}
        }

    }
}
