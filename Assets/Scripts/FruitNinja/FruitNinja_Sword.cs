using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja_Sword : MonoBehaviour
{
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        this.transform.position = (mousePos - new Vector3(Screen.width / 2, Screen.height / 2, 0)) * 0.009f;
    }

    /*void OnTriggerStay(Collider otherCollider)
    {
            //add a point to winning
            success++;
            //change the colour of the object that the cutting zone is on
            otherCollider.gameObject.GetComponent<Renderer>().material.color = Color.red;
            //delete the cutting zone collider
            Destroy(otherCollider);     
    }
    */
}
