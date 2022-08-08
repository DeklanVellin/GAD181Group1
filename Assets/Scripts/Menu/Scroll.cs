using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed; //set in editor through testing

    void Update()
    {
        this.transform.position += Vector3.up * speed;
    }
}
