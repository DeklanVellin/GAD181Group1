using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja_Sword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        this.transform.position = (mousePos - new Vector3(Screen.width / 2, Screen.height / 2, 0)) * 0.009f;
    }
}
