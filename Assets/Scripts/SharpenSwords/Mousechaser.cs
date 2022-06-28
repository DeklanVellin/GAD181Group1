using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousechaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
       // print(mousePos.x + "x, " + mousePos.y + "y");
        this.transform.position = (mousePos - new Vector3(Screen.width / 2, Screen.height / 2, 0))*0.02f;


    }
}
